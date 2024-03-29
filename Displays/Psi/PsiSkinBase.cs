using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Unity.Display.Animation;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ChineseSkinsPort.Displays.Psi;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]

public abstract class PsiSkinBase : ModCustomDisplay
{
    public override string AssetBundleName => "chineseport";

    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        var baseGameObject = node.gameObject;

        // Remove duplicate UDN
        var displayNodes = baseGameObject.GetComponents<UnityDisplayNode>();
        if (displayNodes.Count > 1)
        {
            Object.Destroy(baseGameObject.GetComponent<UnityDisplayNode>());
        }

        // Set outlines
        foreach (var meshRenderer in node.GetMeshRenderers())
        {
            meshRenderer.ApplyOutlineShader();
            meshRenderer.SetOutlineColor(new Color(89 / 255f, 45 / 255f, 36 / 255f));
        }

        // Get Animation clips from animator
        var controller = baseGameObject.transform.GetChild(0).gameObject;
        var animator = controller.GetComponent<Animator>();

        var animClips = animator.runtimeAnimatorController.animationClips;

        var fallClip = animClips.First(clip => clip.name == "Placement").Duplicate();
        var attackClip = animClips.First(clip => clip.name == "AttackLong").Duplicate();
        var attackIdleClip = animClips.First(clip => clip.name == "AttackIdle").Duplicate();
        var psychicBlastClip = animClips.First(clip => clip.name == "PsychicBlast").Duplicate();
        var psionicScreamClip = animClips.First(clip => clip.name == "PsionicScream").Duplicate();
        var upgradeClip = animClips.First(clip => clip.name == "Upgrade").Duplicate();
        var idleClip = animClips.First(clip => clip.name == "Idle").Duplicate();
        var idle1Clip = animClips.First(clip => clip.name == "IdleVariant1").Duplicate();
        var idle2Clip = animClips.First(clip => clip.name == "IdleVariant2").Duplicate();
        var idle3Clip = animClips.First(clip => clip.name == "IdleVariant3").Duplicate();

        // Create animation controller
        var animationController = controller.AddComponent<MonkeyAnimationController>();

        // Config
        animationController.animationStates = new List<AnimationBakerStateConfig>();
        
        animationController.animationStates.Add(new AnimationBakerStateConfig());
        animationController.animationStates.Add(new AnimationBakerStateConfig());
        animationController.animationStates.Add(new AnimationBakerStateConfig());
        animationController.animationStates.Add(new AnimationBakerStateConfig());
        animationController.animationStates.Add(new AnimationBakerStateConfig());
        animationController.animationStates.Add(new AnimationBakerStateConfig());

        animationController.placementConfigs.Add(new AnimationBakerStateConfig());
        animationController.attackIdleConfigs.Add(new AnimationBakerStateConfig());
        animationController.IdleVariants.Add(new AnimationBakerVariantStateConfig());
        animationController.IdleVariants.Add(new AnimationBakerVariantStateConfig());
        animationController.IdleVariants.Add(new AnimationBakerVariantStateConfig());

        animationController.AttackIdleIndex = 7;

        // Idle animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 0, 0, 0, idleClip, InterruptBehaviour.Higher);

        // Attack animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 1, 1, 1, attackClip);

        // Psychic Blast animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 2, 2, 3, psychicBlastClip);
        
        // Psychic Blast animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 3, 3, 2, psionicScreamClip);

        // Upgrade animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 4, 4, 2, upgradeClip);
        
        // Idle again. This doesn't make sense, but this is what Psi animations have.
        Main.ConfigureAnimationBaker(animationController.animationStates, 5, 5, 0, idleClip, InterruptBehaviour.Higher);

        // Falling animation
        Main.ConfigureAnimationBaker(animationController.placementConfigs, 0, 6, 5, fallClip,
            InterruptBehaviour.NoInterrupt);
        
        // Attack idle animation
        Main.ConfigureAnimationBaker(animationController.attackIdleConfigs, 0, 7, 0, attackIdleClip,
            InterruptBehaviour.Higher);

        // Idle variant 1
        Main.ConfigureAnimationBaker(animationController.IdleVariants, 0, 8, 0, idle1Clip);

        // Idle variant 2
        Main.ConfigureAnimationBaker(animationController.IdleVariants, 1, 9, 0, idle2Clip);
        
        // Idle variant 3
        Main.ConfigureAnimationBaker(animationController.IdleVariants, 2, 10, 0, idle3Clip);
    }
}
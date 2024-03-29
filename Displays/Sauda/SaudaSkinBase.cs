using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Unity.Display.Animation;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ChineseSkinsPort.Displays.Sauda;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]

public abstract class SaudaSkinBase : ModCustomDisplay
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

        // Set outline
        var meshRenderer = node.GetMeshRenderer();
        meshRenderer.ApplyOutlineShader();

        meshRenderer.SetOutlineColor(new Color(200 / 255f, 230 / 255f, 230 / 255f));

        // Get Animation clips from animator
        var animator = baseGameObject.GetComponent<Animator>();

        var animClips = animator.runtimeAnimatorController.animationClips;

        var fallClip = animClips.First(clip => clip.name == "Placement").Duplicate();
        var attackLeftClip = animClips.First(clip => clip.name == "AttackLeft").Duplicate();
        var attackRightClip = animClips.First(clip => clip.name == "AttackRight").Duplicate();
        var attackMiddleClip = animClips.First(clip => clip.name == "AttackMiddle").Duplicate();
        var attackStabClip = animClips.First(clip => clip.name == "AttackStab").Duplicate();
        var attackIdleClip = animClips.First(clip => clip.name == "AttackIdle").Duplicate();
        var upgradeClip = animClips.First(clip => clip.name == "Upgrade").Duplicate();
        var idleClip = animClips.First(clip => clip.name == "Idle").Duplicate();
        var idle1Clip = animClips.First(clip => clip.name == "IdleBalance").Duplicate();
        var idle2Clip = animClips.First(clip => clip.name == "IdleSnooze").Duplicate();

        // Create animation controller
        var animationController = baseGameObject.AddComponent<MonkeyAnimationController>();

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
        animationController.placementAnimationIndex = 6;

        // Idle animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 0, 0, 0, idleClip, InterruptBehaviour.Higher);

        // Attack left animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 1, 1, 1, attackLeftClip);
        
        // Attack right animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 2, 2, 3, attackRightClip);
        
        // Attack middle animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 3, 3, 2, attackMiddleClip);
        
        // Attack stab animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 4, 4, 2, attackStabClip);

        // Upgrade animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 5, 5, 2, upgradeClip);
        
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
    }
}
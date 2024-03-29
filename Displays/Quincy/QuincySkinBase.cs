using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Unity.Display.Animation;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ChineseSkinsPort.Displays.Quincy;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]

public abstract class QuincySkinBase : ModCustomDisplay
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

        meshRenderer.SetOutlineColor(new Color(180 / 255f, 108 / 255f, 50 / 255f));

        // Get Animation clips from animator
        var controller = baseGameObject.transform.GetChild(0).gameObject;
        var animator = controller.GetComponent<Animator>();

        var animClips = animator.runtimeAnimatorController.animationClips;

        var fallClip = animClips.First(clip => clip.name == "Placement").Duplicate();
        var attackClip = animClips.First(clip => clip.name == "Attack").Duplicate();
        var attackIdleClip = animClips.First(clip => clip.name == "AttackIdle").Duplicate();
        var specialAttackClip = animClips.First(clip => clip.name == "SpecialAttack").Duplicate();
        var upgradeClip = animClips.First(clip => clip.name == "Upgrade").Duplicate();
        var idleClip = animClips.First(clip => clip.name == "Idle").Duplicate();
        var idle1Clip = animClips.First(clip => clip.name == "Idle01").Duplicate();
        var idle2Clip = animClips.First(clip => clip.name == "Idle02").Duplicate();
        var idle3Clip = animClips.First(clip => clip.name == "Idle03").Duplicate();

        // Create animation controller
        var animationController = controller.AddComponent<MonkeyAnimationController>();

        // Config
        animationController.animationStates = new List<AnimationBakerStateConfig>();
        
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

        // Idle animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 0, 0, 0, idleClip, InterruptBehaviour.Higher);

        // Attack animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 1, 1, 1, attackClip);

        // Storm of arrows attack animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 2, 2, 3, specialAttackClip,
            InterruptBehaviour.NoInterrupt);

        // Upgrade animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 3, 3, 2, upgradeClip,
            InterruptBehaviour.Higher);
        
        // Falling animation
        Main.ConfigureAnimationBaker(animationController.animationStates, 4, 4, 5, fallClip,
            InterruptBehaviour.NoInterrupt);
        
        // Attack idle animation
        Main.ConfigureAnimationBaker(animationController.attackIdleConfigs, 0, 5, 0, attackIdleClip,
            InterruptBehaviour.Higher);

        // Idle variant 1
        Main.ConfigureAnimationBaker(animationController.IdleVariants, 0, 6, 0, idle1Clip);

        // Idle variant 2
        Main.ConfigureAnimationBaker(animationController.IdleVariants, 1, 7, 0, idle2Clip);
        
        // Idle variant 3
        Main.ConfigureAnimationBaker(animationController.IdleVariants, 2, 8, 0, idle3Clip);
    }
}
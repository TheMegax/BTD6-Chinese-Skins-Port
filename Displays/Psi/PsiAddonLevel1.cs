using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Display;
using UnityEngine;

namespace ChineseSkinsPort.Displays.Psi;

// ReSharper disable once UnusedType.Global
public class PsiAddonLevel1 : ModCustomDisplay
{
    public override string AssetBundleName => "chineseport";
    public override string PrefabName => "PsiAddonLevel1";

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
    }
}
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using Il2CppAssets.Scripts.Models.Profile;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppSystem.Collections.Generic;

namespace ChineseSkinsPort;

[SuppressMessage("ReSharper", "InconsistentNaming")]
// ReSharper disable once ClassNeverInstantiated.Global
public class SavePatch
{
    public class SkinsState
    {
        public bool isPendingSave { get; init; }
        public Dictionary<string,string> selectedTowerSkinData {get; init;} = null!;
    }
    
    [HarmonyPatch(typeof(Btd6Player), nameof(Btd6Player.Save))]
    internal class Btd6Player_Save
    {
        [HarmonyPrefix]
        // ReSharper disable once RedundantAssignment
        internal static bool Prefix(Btd6Player __instance, ref SkinsState __state)
        {
            var stSkinData = new Dictionary<string, string>();
            foreach (var keypair in __instance.Data.selectedTowerSkinData)
            {
                stSkinData.Add(keypair.key, keypair.value);
            }
            __state = new SkinsState
            {
                isPendingSave = __instance.IsPendingSave,
                selectedTowerSkinData =  stSkinData
            };
            
            if (__state.isPendingSave && __instance.Data?.HasCompletedTutorial == true)
            {
                CleanProfile(__instance.Data);
            }
            return true;
        }
        
        [HarmonyPostfix]
        internal static void Postfix(Btd6Player __instance, ref SkinsState __state)
        {
            if (__state.isPendingSave && __instance.Data?.HasCompletedTutorial == true)
            {
                UnCleanProfile(__instance.Data, __state.selectedTowerSkinData);
            }
        }
    }
    
    [HarmonyPatch(typeof(Btd6Player), nameof(Btd6Player.SaveNow))]
    internal class Btd6Player_SaveNow
    {
        [HarmonyPrefix]
        // ReSharper disable once RedundantAssignment
        internal static bool Prefix(Btd6Player __instance, ref SkinsState __state)
        {
            var stSkinData = new Dictionary<string, string>();
            foreach (var keypair in __instance.Data.selectedTowerSkinData)
            {
                stSkinData.Add(keypair.key, keypair.value);
            }
            __state = new SkinsState
            {
                isPendingSave = __instance.IsPendingSave,
                selectedTowerSkinData =  stSkinData
            };
            
            if (__state.isPendingSave && __instance.Data?.HasCompletedTutorial == true)
            {
                CleanProfile(__instance.Data);
            }
            return true;
        }
        
        [HarmonyPostfix]
        internal static void Postfix(Btd6Player __instance, ref SkinsState __state)
        {
            if (__state.isPendingSave && __instance.Data?.HasCompletedTutorial == true)
            {
                UnCleanProfile(__instance.Data, __state.selectedTowerSkinData);
            }
        }
    }

    private static void CleanProfile(ProfileModel profile)
    {
        profile.unlockedTowerSkins.Remove("New Year Quincy");
        profile.unlockedTowerSkins.Remove("New Year Psi");
        profile.unlockedTowerSkins.Remove("New Year Sauda");
        
        profile.seenNewTowerSkinNotification.Remove("New Year Quincy");
        profile.seenNewTowerSkinNotification.Remove("New Year Psi");
        profile.seenNewTowerSkinNotification.Remove("New Year Sauda");

        profile.selectedTowerSkinData["Quincy"] = "Quincy";
        profile.selectedTowerSkinData["Psi"] = "Psi";
        profile.selectedTowerSkinData["Sauda"] = "Sauda";
    }
    
    private static void UnCleanProfile(ProfileModel profile, Dictionary<string,string> selectedTowerSkinData)
    {
        profile.unlockedTowerSkins.Add("New Year Quincy");
        profile.unlockedTowerSkins.Add("New Year Psi");
        profile.unlockedTowerSkins.Add("New Year Sauda");
        
        profile.seenNewTowerSkinNotification.Add("New Year Quincy");
        profile.seenNewTowerSkinNotification.Add("New Year Psi");
        profile.seenNewTowerSkinNotification.Add("New Year Sauda");

        profile.selectedTowerSkinData = selectedTowerSkinData;
    }
}
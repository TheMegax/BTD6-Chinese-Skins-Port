using MelonLoader;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using ChineseSkinsPort;
using Il2CppAssets.Scripts.Data;
using Il2CppAssets.Scripts.Data.Skins;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display.Animation;
using Il2CppAssets.Scripts.Utils;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppNinjaKiwi.Common;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[assembly: MelonInfo(typeof(ChineseSkinsPort.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ChineseSkinsPort;

public class Main : BloonsTD6Mod
{
    // TODO: Sauda's ability animations haven't been implemented. Find a way to implement it myself.
    // TODO: Psi's level 1 head had some annoying polygons that I haven't been able to get rid of. Find a way to modify the model without breaking it.
    
    private bool _applyChanges = true;

    public override void OnGameModelLoaded(GameModel model)
    {
        if (!_applyChanges) return;

        // Quincy //
        var quincyPortraitsContainer = new PortraitContainer
        {
            items = new List<StorePortraits>()
        };
        quincyPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "1",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl3]" }
            }
        );
        quincyPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "3",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl3]" }
            }
        );
        quincyPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "7",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl7]" }
            }
        );
        quincyPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "10",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl10]" }
            }
        );
        quincyPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "20",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl20]" }
            }
        );
        
        var quincySwapPrefabContainer = new SwapPrefabContainer
        {
            items = new List<SwapPrefab>()
        };
        quincySwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "cddca470955e4e64da4063f1aa110f2b" },
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearQuincyLevel1"}
            }
        );
        quincySwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "f428ba21a9db9c441bf4b090c154edeb" },
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearQuincyLevel3"}
            }
        );
        quincySwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "9703101b845bf6e42a7e22e769cb0c40" },
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearQuincyLevel7"}
            }
        );
        quincySwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "f08231d7f2ac6f1438f76a6120910ccb" },
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearQuincyLevel10"}
            }
        );
        quincySwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "3db6fc68b301c6d48aac832f6894c384" },
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearQuincyLevel20"}
            }
        );
        
        var quincySwapSpriteContainer = new SwapSpriteContainer
        {
            items = new List<SwapSprite>()
        };
        quincySwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "f49307e95b921974cb9e1baadf2352fb" },
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl3]" }
            }
        );
        quincySwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "9ab0f5e080bdcc64aa05f13996e32fe9" },
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl3]" }
            }
        );
        quincySwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "4e77bdcfb2c17d04eb9e379e4ef6ef1c" },
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl7]" }
            }
        );
        quincySwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "9f09f9e47a9e71a4fa8e607df6077456" },
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl10]" }
            }
        );
        quincySwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "ec7590b408bb7014d93b3481c1873f93" },
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl20]" }
            }
        );
        quincySwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "MonkeyIcons[QuincyIcon]" },
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-QuincyNewYearPortraitLvl3]" }
            }
        );

        var quincySwapAudioContainer = new SwapAudioContainer
        {
            items = new List<SwapAudio>()
        };

        var quincySwapOverlayContainer = new SwapOverlayContainer
        {
            items = new List<SwapOverlay>()
        };
        
        // Psi
        var psiPortraitsContainer = new PortraitContainer
        {
            items = new List<StorePortraits>()
        };
        psiPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "1",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl1]" }
            }
        );
        psiPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "3",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl3]" }
            }
        );
        psiPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "10",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl8]" }
            }
        );
        psiPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "20",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl20]" }
            }
        );
        
        var psiSwapPrefabContainer = new SwapPrefabContainer
        {
            items = new List<SwapPrefab>()
        };
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "7dc46f26af35f39449aa94b70c3a53a1" }, // lvl 1
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel1"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "d986bbeb30f071248914d0d89a532def" }, // lvl 3
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel3"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "23a476bfc228dd146a6c88a56a5592b1" }, // lvl 8
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel3"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "8ccd0a45224d44540a1e05b54d0fbbbb" }, // lvl 9
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel3"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "a88b2df37eceaec458870e5e73791375" }, // lvl 10
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel10"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "17544ef0fed812948895b6fb84d4cc3e" }, // lvl 17
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel10"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "f15563c12e665644ca054a9ec92f51b7" }, // lvl 20
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearPsiLevel20"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "e5daf50bbf24cde4aab87561b268251c" }, // addon lvl 1
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-PsiAddonLevel1"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "73415b8f4dc2df945a127504dde9bcde" }, // addon lvl 10
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-PsiAddonLevel10"}
            }
        );
        psiSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "7576b2ab9c9246c42bb06d69d0de818a" }, // addon lvl 20
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-PsiAddonLevel20"}
            }
        );
        
        var psiSwapSpriteContainer = new SwapSpriteContainer
        {
            items = new List<SwapSprite>()
        };
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "d945e81257cfd044897649ff99c17fb4" }, // lvl 1
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl1]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "53eba3020aa5239499a5fc0ba04b561e" }, // lvl 3
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl3]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "20ce6bc04e1f56745a343a09629e937e" }, // lvl 8
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl3]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "25eb0d20ee2e49f4a8acaa2722054a1f" }, // lvl 9
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl3]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "60fc67735df77c64899ff222942c96f9" }, // lvl 10
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl8]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "3ee272b5c12745a4fb631784ef125b62" }, // lvl 17
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl8]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "75dfa503dcac30740b78e815ff664d73" }, // lvl 20
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl20]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "MonkeyIcons[PsiIcon]" }, // Psi icon
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-PsiNewYearPortraitLvl1]" }
            }
        );
        psiSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "b1fe2632ed34e5345ab42b2e9b80d301" }, // Scream effect
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-MandalaLV20]" }
            }
        );
        
        var psiSwapAudioContainer = new SwapAudioContainer
        {
            items = new List<SwapAudio>()
        };
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "2ec103c1a89a2dc46873262713bd47b1" }, // Place 1
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearPlace")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "60b663ec35ef9cb4f9ddb39d4261dc74" }, // Place 2
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearPlace")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "12baadbccd77e764f931fff86d7bfd99" }, // Select 1
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect01")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "9f4da4e0e6f70db40b3de33ec3dc91b9" }, // Select 2
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect02")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "14278b3296e98c44dbeb9872efcadf9c" }, // Select 3
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect03")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "0a648a159cafe544db91e2f7a57191ca" }, // Select 4
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect04")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "8398760936ed0a942b64a5fe75a9475b" }, // Select 5
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect05")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "a3f42a87448d2f94c9caeb1a2bede3c0" }, // Select 6
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect05")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "768ea9c5f05530e40a503a10971fe2e3" }, // Select alt 1
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect04")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "6f2db2908559f6344b9bed6ddc464772" }, // Select alt 2
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearSelect03")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "734c58781ca3dea4eb0ab357f880efa0" }, // Unlock
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUnlock")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "318d3df913dfc9841ba00a3d2af40304" }, // Upgrade 01
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade01")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "c45444b6c3a6c504b9ce463482c01b90" }, // Upgrade 02
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade02")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "02ad12cb9d10f6f47af214b3ae15b052" }, // Upgrade 03
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade03")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "24decd13195c1d142a306a99626f5fea" }, // Upgrade 04
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade04")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "5e1291d5416b4f943ba179a2b805fb3f" }, // Upgrade 05
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade05")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "2e728b7ea006d7540ac9a76da067e654" }, // Upgrade 06
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade04")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "cd0e4fba020a8a44d9584a0ecfe74e84" }, // Upgrade 07
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade03")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "1f1f69f88a0109e4ca21259910cad2e6" }, // Upgrade 08
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgrade02")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "4f204ccf132de5746b47c3bc03d7abdf" }, // Upgrade max
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearUpgradeMax")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "b8b82505db537fa4d9bac0d49627fdbb" }, // Warning Moab
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearWarningMoab")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "deedf11caf821954ea6c6532f13fd107" }, // Warning Bfb
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearWarningBfb")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "3b1c2b67dcef50b46bfef9c9636cb804" }, // Warning Zomg
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearWarningZomg")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "7aecd74880d1d7941961cb4c51effdcf" }, // Warning Ddt
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearWarningDdt")
        });
        
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "dd255cbda5cc06d419894fd311ebaf5b" }, // Ability 3
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearAbility3")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "cadb35e40baee4e43b0811a46b167dce" }, // Ability 3 alt
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearAbility3")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "1595f59017d5b7c43a5dfaeb99319f39" }, // Ability 10
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearAbility10")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "3106f6d6a6c9eb84b824ed2cdb0d3b48" }, // Ability 10 alt
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearAbility10")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "61f96be9248de294e94e8ad5b44ac751" }, // Leak 1
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearLeak")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "c5f21219ded6c3643ba677c2744f1b08" }, // Leak 2
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearLeak")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "281b2c4821906894ebcc1d98078d3163" }, // Warning Bad
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearWarningBad")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "29d493505c0dcb64b9b8615db6807b9d" }, // Moab Destroyed 1
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearMoabDestroyed01")
        });
        psiSwapAudioContainer.items.Add(new SwapAudio
        {
            assetToReplace = new AudioSourceReference { guidRef = "80988e1f4d0d9f446a1e4e1f0a7b5f18" }, // Moab Destroyed 2
            assetReplacement = ModContent.GetAudioSourceReference(this, "PsiNewYearMoabDestroyed02")
        });

        var psiSwapOverlayContainer = new SwapOverlayContainer
        {
            items = new List<SwapOverlay>()
        };
        
        // Sauda
        var saudaPortraitsContainer = new PortraitContainer
        {
            items = new List<StorePortraits>()
        };
        saudaPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "1",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl1]" }
            }
        );
        saudaPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "3",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl3]" }
            }
        );
        saudaPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "10",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl10]" }
            }
        );
        saudaPortraitsContainer.items.Add(new StorePortraits
            {
                levelTxt = "20",
                asset = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl20]" }
            }
        );
        
        var saudaSwapPrefabContainer = new SwapPrefabContainer
        {
            items = new List<SwapPrefab>()
        };
        saudaSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "f7ae99f3aa4f5d5488498afec401df79" }, // lvl 1
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearSaudaLevel1"}
            }
        );
        saudaSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "009016d8031477048bf86c9371fdf077" }, // lvl 3
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearSaudaLevel3"}
            }
        );
        saudaSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "615d7f6284729bb47b88ca5e6f7fe700" }, // lvl 10
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearSaudaLevel10"}
            }
        );
        saudaSwapPrefabContainer.items.Add(new SwapPrefab
            {
                assetToReplace = new PrefabReference { guidRef = "ab00cf62f7e084648814fc8a9c1a4052" }, // lvl 20
                assetReplacement = new PrefabReference {guidRef = "ChineseSkinsPort-NewYearSaudaLevel20"}
            }
        );
        
        var saudaSwapSpriteContainer = new SwapSpriteContainer
        {
            items = new List<SwapSprite>()
        };
        saudaSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "62c0ff1c4bd003f4cb39b346bc70ce8e" }, // lvl 1
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl1]" }
            }
        );
        saudaSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "b02425d2dfb113244bf770acf6e7b65e" }, // lvl 3
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl3]" }
            }
        );
        saudaSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "fefa503a6f02ffd4daf096b761c80274" }, // lvl 10
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl10]" }
            }
        );
        saudaSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "437e2270d2e17054b84d6cb471f78202" }, // lvl 20
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl20]" }
            }
        );
        saudaSwapSpriteContainer.items.Add(new SwapSprite
            {
                assetToReplace = new SpriteReference { guidRef = "MonkeyIcons[SaudaIcon]" }, // Psi icon
                assetReplacement = new SpriteReference { guidRef = "Ui[ChineseSkinsPort-SaudaNewYearPortraitLvl1]" }
            }
        );
        
        var saudaSwapAudioContainer = new SwapAudioContainer
        {
            items = new List<SwapAudio>()
        };

        var saudaSwapOverlayContainer = new SwapOverlayContainer
        {
            items = new List<SwapOverlay>()
        };

        var skinDataArray = new Il2CppReferenceArray<SkinData>(3)
        {
            [0] = ScriptableObject.CreateInstance<SkinData>(),
            [0] =
            {
                name = "New Year Quincy",
                skinName = "NewYearQuincySkinName",
                baseTowerName = "Quincy",
                mmCost = 0,
                isDefaultTowerSkin = false,
                description = "NewYearQuincySkinDescription",
                fontMaterial = "9c5f9efd0f4694e09ad1831bbea2e54e,Btd6FontTitleSDFHeroBlue",
                textMaterialId = "Quincy",
                icon = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-HeroIconQuincyNewYear]"},
                iconSquare = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-HeroIconSquareQuincyNewYear]"},
                backgroundBanner = new PrefabReference {guidRef = "b862f62bb69a3534f8ef591b6f5e7170"},
                unlockedEventSound = new AudioSourceReference {guidRef = "bc0f7e77871e6fb4ab5eacedfc08c082"},
                unlockedVoiceSound = new AudioSourceReference {guidRef = "2901d680540a73e46a394390771742bc"},
                SwapPrefabContainer = quincySwapPrefabContainer,
                StorePortraitsContainer = quincyPortraitsContainer,
                SwapSpriteContainer = quincySwapSpriteContainer,
                SwapAudioContainer = quincySwapAudioContainer,
                SwapOverlayContainer = quincySwapOverlayContainer,
                backgroundColourTintOverride = new Color(r:0f, g:0.522f, b:0.624f)
            },
            [1] = ScriptableObject.CreateInstance<SkinData>(),
            [1] =
            {
                name = "New Year Psi",
                skinName = "NewYearPsiSkinName",
                baseTowerName = "Psi",
                mmCost = 0,
                isDefaultTowerSkin = false,
                description = "NewYearPsiSkinDescription",
                fontMaterial = "d05db8abfbdb849e688fea3527f5a2fc,Btd6FontTitleSDFHeroYellow",
                textMaterialId = "Psi",
                icon = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-HeroIconPsiNewYear]"},
                iconSquare = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-HeroIconSquarePsiNewYear]"},
                backgroundBanner = new PrefabReference {guidRef = "6d3700655fa530b4b8a6917c1caab90c"},
                unlockedEventSound = new AudioSourceReference {guidRef = "bc0f7e77871e6fb4ab5eacedfc08c082"},
                unlockedVoiceSound = ModContent.GetAudioSourceReference(this, "PsiNewYearUnlock"),
                SwapPrefabContainer = psiSwapPrefabContainer,
                StorePortraitsContainer = psiPortraitsContainer,
                SwapSpriteContainer = psiSwapSpriteContainer,
                SwapAudioContainer = psiSwapAudioContainer,
                SwapOverlayContainer = psiSwapOverlayContainer,
                backgroundColourTintOverride = new Color(r:0.306f, g:0.341f, b:0.698f)
            },
            [2] = ScriptableObject.CreateInstance<SkinData>(),
            [2] =
            {
                name = "New Year Sauda",
                skinName = "NewYearSaudaSkinName",
                baseTowerName = "Sauda",
                mmCost = 0,
                isDefaultTowerSkin = false,
                description = "NewYearSaudaSkinDescription",
                fontMaterial = "122d32ee3ec5447d280149e441b48721,Btd6FontTitleSDFHeroSteel",
                textMaterialId = "Sauda",
                icon = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-HeroIconSaudaNewYear]"},
                iconSquare = new SpriteReference {guidRef = "Ui[ChineseSkinsPort-HeroIconSquareSaudaNewYear]"},
                backgroundBanner = new PrefabReference {guidRef = "b149da122019aaf47bb7cd1a41bb7774"},
                unlockedEventSound = new AudioSourceReference {guidRef = "bc0f7e77871e6fb4ab5eacedfc08c082"},
                unlockedVoiceSound = new AudioSourceReference {guidRef = "6c84fae31334b074f96da54402bcd1d8"},
                SwapPrefabContainer = saudaSwapPrefabContainer,
                StorePortraitsContainer = saudaPortraitsContainer,
                SwapSpriteContainer = saudaSwapSpriteContainer,
                SwapAudioContainer = saudaSwapAudioContainer,
                SwapOverlayContainer = saudaSwapOverlayContainer,
                backgroundColourTintOverride = new Color(r:0.541f, g:0.169f, b:0.325f)
            }
        };
        
        GameData.Instance.skinsData.AddSkins(skinDataArray);
        
        // Quincy
        LocalizationManager.Instance.defaultTable.Add("NewYearQuincySkinDescription", 
            "Quincy sometimes dreams of himself in another time and space, resisting bloons on the Great Wall, " +
            "passionately and loyally guarding his home.");
        
        LocalizationManager.Instance.defaultTable.Add("NewYearQuincySkinName", 
            "General Quincy Skin");
        
        LocalizationManager.Instance.defaultTable.Add("NewYearQuincySkinNameFull", 
            "General Quincy");
        
        // Psi
        LocalizationManager.Instance.defaultTable.Add("NewYearPsiSkinDescription", 
            "The mysterious Chinese dragon has extraordinary sensory abilities " +
            "and can exert amazing combat effectiveness on the battlefield.");
        
        LocalizationManager.Instance.defaultTable.Add("NewYearPsiSkinName", 
            "Qinglong Psi Skin");
        
        LocalizationManager.Instance.defaultTable.Add("NewYearPsiSkinNameFull", 
            "Qinglong Psi");

        
        // Sauda
        LocalizationManager.Instance.defaultTable.Add("NewYearSaudaSkinDescription", 
            "Don’t be fooled by her cute appearance, Sauda is a superpowered catwoman!");
        
        LocalizationManager.Instance.defaultTable.Add("NewYearSaudaSkinName", 
            "Sauda Catwoman Skin");
        
        LocalizationManager.Instance.defaultTable.Add("NewYearSaudaSkinNameFull", 
            "Catwoman Sauda");

        /*foreach (var skin in GameData.Instance.skinsData.SkinList.items)
        {
            if (!skin.skinName.Contains("Sauda")) continue;
            
            ModHelper.Msg<Main>("Skin: " + skin.skinName);

            foreach (var sItem in skin.SwapPrefabContainer.items)
            {
                ModHelper.Msg<Main>("To replace:    " + sItem.assetToReplace.guidRef);
                ModHelper.Msg<Main>("Replacing:     " + sItem.assetReplacement.guidRef);
            }
        }*/

        _applyChanges = false;
    }

    public override void OnMainMenu()
    {
        Game.Player.UnlockHeroSkin("Quincy", "New Year Quincy");
        Game.Player.UnlockHeroSkin("Psi", "New Year Psi");
        Game.Player.UnlockHeroSkin("Sauda", "New Year Sauda");
    }
    
    public static Object? GetBundledAsset(string name)
    {
        var bundle = ModContent.GetBundle(ModHelper.GetMod("ChineseSkinsPort"), "chineseport");
        return bundle.LoadAsset(name);
    }

    public static void ConfigureAnimationBaker<T>(
        List<T> list, int index, int animationIndex, int priority, AnimationClip animationClip,
        InterruptBehaviour interruptBehaviour = InterruptBehaviour.SameOrHigher) where T : AnimationBakerStateConfig
    {
        var animBaker = list.ToArray()[index];
        animBaker.animationIndex = animationIndex;
        animBaker.priority = priority;
        animBaker.animationClip = animationClip;
        animBaker.interruptibleBehaviour = interruptBehaviour;
    }
}
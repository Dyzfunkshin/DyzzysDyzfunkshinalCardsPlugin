using BepInEx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[BepInDependency("com.willis.rounds.unbound")]
[BepInDependency("pykess.rounds.plugins.moddingutils")]
[BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")]
[BepInPlugin(ModId, ModName, "0.0.1")]

[BepInProcess("Rounds.exe")]
public class DyzzysDyzfunkshinalCardsPlugin : BaseUnityPlugin 
{
    internal static string modInitials = "DYZ";

    internal static AssetBundle assets;
    private const string ModId = "com.dyzfunkshin.rounds.dyzzysdyzfunkshinalcards";
    private const string ModName = "Dyzzy's Dyzfunkshinal Cards";


    void Awake()
    {
        assets = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("dyzzys_assets", typeof(DyzzysDyzfunkshinalCardsPlugin).Assembly);

        Logger.Log(BepInEx.Logging.LogLevel.Info, "Dyzzy's Dyzfunkshinal Plugin Loaded!");
    }

    void Start()
    {
        assets.LoadAsset<GameObject>("ModCards").GetComponent<CardHolder>().RegisterCards();
     
        Logger.Log(BepInEx.Logging.LogLevel.Info, "Dyzzy's Dyzfunkshinal Cards Loaded!");
    }
}
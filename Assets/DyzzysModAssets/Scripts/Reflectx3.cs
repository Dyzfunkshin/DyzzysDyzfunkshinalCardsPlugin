using System.Collections;
using System.Collections.Generic;
using UnboundLib.Cards;
using UnityEngine;

public class Reflectx3 : CustomCard
{
    public GameObject cardArt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
    {
        gun.reflects += 3;
    }

    protected override GameObject GetCardArt()
    {
        return cardArt;
    }

    protected override string GetDescription()
    {
        return "Adds 3 bounces";
    }

    protected override CardInfo.Rarity GetRarity()
    {
        return CardInfo.Rarity.Common;
    }

    protected override CardInfoStat[] GetStats()
    {
        return cardInfo.cardStats;
    }

    protected override CardThemeColor.CardThemeColorType GetTheme()
    {
        return CardThemeColor.CardThemeColorType.TechWhite;
    }

    protected override string GetTitle()
    {
        return "Reflect x3";
    }
}

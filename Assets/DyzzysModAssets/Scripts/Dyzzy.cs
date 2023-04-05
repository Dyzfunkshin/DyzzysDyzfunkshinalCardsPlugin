﻿using System.Collections;
using System.Collections.Generic;
using UnboundLib.Cards;
using UnityEngine;

public class Dyzzy : CustomCard
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
        gun.reflects += 5;
        gun.damage *= 5;
        gun.reloadTime /= 5;
        gun.ammo *= 5;
    }

    protected override GameObject GetCardArt()
    {
        return cardArt;
    }

    protected override string GetDescription()
    {
        return "Increases Bounces, Damage, and Ammo, and Decreases Reload time.";
    }

    protected override CardInfo.Rarity GetRarity()
    {
        return CardInfo.Rarity.Rare;
    }

    protected override CardInfoStat[] GetStats()
    {
        CardInfoStat[] info = new CardInfoStat[]
        {
            new CardInfoStat()
        };

        return info;
    }

    protected override CardThemeColor.CardThemeColorType GetTheme()
    {
        return CardThemeColor.CardThemeColorType.FirepowerYellow;
    }

    protected override string GetTitle()
    {
        return "Dyzzy";
    }
}

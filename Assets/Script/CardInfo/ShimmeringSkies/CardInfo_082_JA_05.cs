using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_05 : CardInfo
{
    public CardInfo_082_JA_05()
    {
        this.cardNo = "082_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "スクループ";
        this.cardName2 = "ゲスな反乱者";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JustinRunfola;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

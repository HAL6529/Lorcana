using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_05 : CardInfo
{
    public CardInfo_058_JA_05()
    {
        this.cardNo = "058_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "カミロ・マドリガル";
        this.cardName2 = "家族のまねっ子";
        this.power = 3;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

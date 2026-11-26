using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_14 : CardInfo
{
    public CardInfo_170_JA_14()
    {
        this.cardNo = "170_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "サンフランソウキョウ工科大学";
        this.cardName2 = "ハニー・レモンのラボ";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DouglasDeLaHoz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

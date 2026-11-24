using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_12 : CardInfo
{
    public CardInfo_121_JA_12()
    {
        this.cardNo = "121_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャック・ジャック・パー";
        this.cardName2 = "能力未知数";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

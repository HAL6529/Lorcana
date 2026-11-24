using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_12 : CardInfo
{
    public CardInfo_061_JA_12()
    {
        this.cardNo = "061_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ダッシュ・パー";
        this.cardName2 = "溶岩ランナー";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

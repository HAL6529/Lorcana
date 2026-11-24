using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_12 : CardInfo
{
    public CardInfo_179_JA_12()
    {
        this.cardNo = "179_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Mrs.インクレディブル";
        this.cardName2 = "ヘレン・パー";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

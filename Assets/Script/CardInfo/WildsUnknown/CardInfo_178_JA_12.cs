using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_12 : CardInfo
{
    public CardInfo_178_JA_12()
    {
        this.cardNo = "178_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ヴァイオレット・パー";
        this.cardName2 = "ガマンの限界";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

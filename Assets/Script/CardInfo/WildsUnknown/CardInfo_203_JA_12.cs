using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_12 : CardInfo
{
    public CardInfo_203_JA_12()
    {
        this.cardNo = "203_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ファットキャットのカジノ";
        this.cardName2 = "うさんくさい秘密基地";
        this.power = 1;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

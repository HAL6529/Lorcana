using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_200_JA_12 : CardInfo
{
    public CardInfo_200_JA_12()
    {
        this.cardNo = "200_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ガジェットの弓矢";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

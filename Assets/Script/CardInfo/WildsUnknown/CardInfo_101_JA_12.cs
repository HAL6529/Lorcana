using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_12 : CardInfo
{
    public CardInfo_101_JA_12()
    {
        this.cardNo = "101_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "メリダの弓";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AurelieLise_Anne;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

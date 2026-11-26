using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_14 : CardInfo
{
    public CardInfo_101_JA_14()
    {
        this.cardNo = "101_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ピザの斜塔";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

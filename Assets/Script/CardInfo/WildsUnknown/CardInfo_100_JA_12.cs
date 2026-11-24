using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_12 : CardInfo
{
    public CardInfo_100_JA_12()
    {
        this.cardNo = "100_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ジャイロ脱出機";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

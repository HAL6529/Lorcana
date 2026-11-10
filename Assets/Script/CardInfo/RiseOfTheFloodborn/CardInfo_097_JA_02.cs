using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_02 : CardInfo
{
    public CardInfo_097_JA_02()
    {
        this.cardNo = "097_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ƒsƒ‡ƒ“ƒsƒ‡ƒ“";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.BillRobinson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

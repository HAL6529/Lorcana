using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_06 : CardInfo
{
    public CardInfo_164_JA_06()
    {
        this.cardNo = "164_JA_06";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "óÕÇ…Ç»ÇÈÇÌÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ThereseVildefall;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

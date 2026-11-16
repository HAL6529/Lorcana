using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_06 : CardInfo
{
    public CardInfo_030_JA_06()
    {
        this.cardNo = "030_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "Ç±Ç±Ç»ÇÁà¿êS";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SimoneTentoni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

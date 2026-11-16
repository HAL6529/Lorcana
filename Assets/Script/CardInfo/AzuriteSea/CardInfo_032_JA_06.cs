using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_06 : CardInfo
{
    public CardInfo_032_JA_06()
    {
        this.cardNo = "032_JA_06";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ÉvÅ[äCëØícÇÃëD";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KaitlinCuthbertson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_06 : CardInfo
{
    public CardInfo_034_JA_06()
    {
        this.cardNo = "034_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "100エーカーの島";
        this.cardName2 = "プーたちの居場所";
        this.power = 1;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.AndreasRocha;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

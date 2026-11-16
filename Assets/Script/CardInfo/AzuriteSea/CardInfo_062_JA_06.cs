using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_06 : CardInfo
{
    public CardInfo_062_JA_06()
    {
        this.cardNo = "062_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ñÇñ@ÇçÏÇÈÇÊÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

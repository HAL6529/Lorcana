using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_06 : CardInfo
{
    public CardInfo_035_JA_06()
    {
        this.cardNo = "035_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "シュガーラッシュスピードウェイ";
        this.cardName2 = "ゴールライン";
        this.power = 6;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RobertoGatto;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.SuperRare;
    }
}

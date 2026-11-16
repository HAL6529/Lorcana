using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_06 : CardInfo
{
    public CardInfo_095_JA_06()
    {
        this.cardNo = "095_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Heffalumps and Woozles";
        this.cardName2 = "ズオウとヒイタチ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DomenicoRusso;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_14 : CardInfo
{
    public CardInfo_062_JA_14()
    {
        this.cardNo = "062_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "HIGITUS FIGITUS";
        this.cardName2 = "ヒギタス・フィギタス";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JulieVu;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

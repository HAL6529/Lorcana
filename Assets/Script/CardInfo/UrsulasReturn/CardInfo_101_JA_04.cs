using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_04 : CardInfo
{
    public CardInfo_101_JA_04()
    {
        this.cardNo = "101_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "âBÇ≥ÇÍÇΩì¸ÇËç]";
        this.cardName2 = "ê√Ç©Ç»âBÇÍâ∆";
        this.power = 1;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RobertoGatto;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

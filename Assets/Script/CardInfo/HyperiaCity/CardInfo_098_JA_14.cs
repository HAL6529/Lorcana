using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_14 : CardInfo
{
    public CardInfo_098_JA_14()
    {
        this.cardNo = "098_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ふざけたあざけり";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LenSimonAndHayleyEvans;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

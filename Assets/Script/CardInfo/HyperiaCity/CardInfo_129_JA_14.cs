using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_14 : CardInfo
{
    public CardInfo_129_JA_14()
    {
        this.cardNo = "129_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "限界を押し上げろ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DomenicoRusso;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

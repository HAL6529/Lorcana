using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_14 : CardInfo
{
    public CardInfo_100_JA_14()
    {
        this.cardNo = "100_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ベルの都市観光ガイド";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_12 : CardInfo
{
    public CardInfo_066_JA_12()
    {
        this.cardNo = "066_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "スーパースーツ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_12 : CardInfo
{
    public CardInfo_068_JA_12()
    {
        this.cardNo = "068_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ストーンサークル";
        this.cardName2 = "伝説の場所";
        this.power = 3;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

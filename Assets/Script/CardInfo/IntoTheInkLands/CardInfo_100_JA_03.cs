using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_03 : CardInfo
{
    public CardInfo_100_JA_03()
    {
        this.cardNo = "100_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ド・ビル邸";
        this.cardName2 = "クルエラの屋敷";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RyanMoeck;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

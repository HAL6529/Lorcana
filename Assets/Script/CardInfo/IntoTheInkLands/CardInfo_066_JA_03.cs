using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_03 : CardInfo
{
    public CardInfo_066_JA_03()
    {
        this.cardNo = "066_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "魔の山";
        this.cardName2 = "マレフィセントの城";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JimmyLo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

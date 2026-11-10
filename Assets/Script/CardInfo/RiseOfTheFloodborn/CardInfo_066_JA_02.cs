using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_02 : CardInfo
{
    public CardInfo_066_JA_02()
    {
        this.cardNo = "066_JA_02";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "クロッケーのマーケット";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

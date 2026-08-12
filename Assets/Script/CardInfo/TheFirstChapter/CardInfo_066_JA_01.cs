using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_01 : CardInfo
{
    public CardInfo_066_JA_01()
    {
        this.cardNo = "066_JA_01";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "–‚–@‚Ì‹¾";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Andrew Trabbold";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

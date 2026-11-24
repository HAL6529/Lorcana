using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_12 : CardInfo
{
    public CardInfo_095_JA_12()
    {
        this.cardNo = "095_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "STRANGE THINGS";
        this.cardName2 = "すべてがストレンジ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_01 : CardInfo
{
    public CardInfo_098_JA_01()
    {
        this.cardNo = "098_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "”w‚·‚¶‚ªƒ]ƒNƒb!";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Giulia Riva";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

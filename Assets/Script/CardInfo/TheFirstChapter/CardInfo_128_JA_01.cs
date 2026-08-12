using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_01 : CardInfo
{
    public CardInfo_128_JA_01()
    {
        this.cardNo = "128_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "BE PREPARED";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Jared Nickerl";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

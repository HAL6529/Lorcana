using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_01 : CardInfo
{
    public CardInfo_030_JA_01()
    {
        this.cardNo = "030_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "PART OF YOUR WORLD";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Samanta Erdini";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

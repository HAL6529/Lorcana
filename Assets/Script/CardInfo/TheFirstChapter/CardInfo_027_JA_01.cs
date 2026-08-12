using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_01 : CardInfo
{
    public CardInfo_027_JA_01()
    {
        this.cardNo = "027_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "HAKUNA MATATA";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Juan Diego Leon";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

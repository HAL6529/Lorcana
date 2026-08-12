using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_01 : CardInfo
{
    public CardInfo_064_JA_01()
    {
        this.cardNo = "064_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "FRIENDS ON THE OTHER SIDE";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Amber Kommavongsa";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

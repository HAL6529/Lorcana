using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_01 : CardInfo
{
    public CardInfo_062_JA_01()
    {
        this.cardNo = "062_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "‚¤‚ë‚½‚¦‚é‚Ì‚¶‚á!";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Kendall Hale";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

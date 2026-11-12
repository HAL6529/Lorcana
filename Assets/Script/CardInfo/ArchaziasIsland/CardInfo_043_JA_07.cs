using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_07 : CardInfo
{
    public CardInfo_043_JA_07()
    {
        this.cardNo = "043_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ケーナイン･クランチー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_07 : CardInfo
{
    public CardInfo_080_JA_07()
    {
        this.cardNo = "080_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "魔法のムーブメント";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JenniferWu;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

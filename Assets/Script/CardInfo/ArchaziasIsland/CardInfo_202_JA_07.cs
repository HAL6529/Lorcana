using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_07 : CardInfo
{
    public CardInfo_202_JA_07()
    {
        this.cardNo = "202_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ダブル・トラブル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NatalieDombois;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

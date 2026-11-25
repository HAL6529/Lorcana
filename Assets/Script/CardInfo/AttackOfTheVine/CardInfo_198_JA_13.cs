using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_13 : CardInfo
{
    public CardInfo_198_JA_13()
    {
        this.cardNo = "198_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "震えあがれ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.VivTanner;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

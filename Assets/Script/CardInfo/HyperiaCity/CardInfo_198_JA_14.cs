using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_14 : CardInfo
{
    public CardInfo_198_JA_14()
    {
        this.cardNo = "198_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "インク爆発";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Kaluba;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

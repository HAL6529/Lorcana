using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_12 : CardInfo
{
    public CardInfo_170_JA_12()
    {
        this.cardNo = "170_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マドリガル家のおうち";
        this.cardName2 = "中庭";
        this.power = 1;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

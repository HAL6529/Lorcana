using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_12 : CardInfo
{
    public CardInfo_133_JA_12()
    {
        this.cardNo = "133_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "危なっかしい計画";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

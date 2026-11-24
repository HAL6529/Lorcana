using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_12 : CardInfo
{
    public CardInfo_136_JA_12()
    {
        this.cardNo = "136_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "レヴィアタンの巣";
        this.cardName2 = "危険な海域";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_14 : CardInfo
{
    public CardInfo_136_JA_14()
    {
        this.cardNo = "136_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "カーンスタジアム";
        this.cardName2 = "最先端施設";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GabrielaGalvan;
        this.classList = new List<EnumController.Class> { EnumController.Class.HyperiaCity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

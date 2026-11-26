using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_14 : CardInfo
{
    public CardInfo_169_JA_14()
    {
        this.cardNo = "169_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ケミバッグ2.0";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlyssaLee;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

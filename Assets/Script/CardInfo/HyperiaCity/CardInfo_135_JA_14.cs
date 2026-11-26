using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_14 : CardInfo
{
    public CardInfo_135_JA_14()
    {
        this.cardNo = "135_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "死者の国";
        this.cardName2 = "マリーゴールドの橋";
        this.power = 1;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaimePuga;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

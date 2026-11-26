using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_14 : CardInfo
{
    public CardInfo_033_JA_14()
    {
        this.cardNo = "033_JA_14";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ママ・イメルダの許し";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

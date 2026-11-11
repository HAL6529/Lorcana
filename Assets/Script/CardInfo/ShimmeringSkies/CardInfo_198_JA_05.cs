using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_05 : CardInfo
{
    public CardInfo_198_JA_05()
    {
        this.cardNo = "198_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "物陰にダックれろ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GianlucaBarone;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

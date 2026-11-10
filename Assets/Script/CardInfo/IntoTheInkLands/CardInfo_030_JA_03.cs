using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_03 : CardInfo
{
    public CardInfo_030_JA_03()
    {
        this.cardNo = "030_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "アトランティスの心臓";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ElliotBaumAndVivTanner;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

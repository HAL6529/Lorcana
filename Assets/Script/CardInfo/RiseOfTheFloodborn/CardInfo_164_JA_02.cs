using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_02 : CardInfo
{
    public CardInfo_164_JA_02()
    {
        this.cardNo = "164_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "”­ŽË";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

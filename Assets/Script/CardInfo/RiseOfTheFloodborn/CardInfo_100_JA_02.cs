using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_02 : CardInfo
{
    public CardInfo_100_JA_02()
    {
        this.cardNo = "100_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "åQÇÍÇÃêÌèp";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DonAguillo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

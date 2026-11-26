using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_14 : CardInfo
{
    public CardInfo_167_JA_14()
    {
        this.cardNo = "167_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "試作ケミボール";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GrzegorzKrysinski;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

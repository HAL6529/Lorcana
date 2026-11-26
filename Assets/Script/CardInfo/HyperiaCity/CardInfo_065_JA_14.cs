using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_14 : CardInfo
{
    public CardInfo_065_JA_14()
    {
        this.cardNo = "065_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "創造の閃き";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Jaryclea;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

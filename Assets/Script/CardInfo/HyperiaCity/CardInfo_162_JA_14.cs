using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_14 : CardInfo
{
    public CardInfo_162_JA_14()
    {
        this.cardNo = "162_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "もはや暗黒時代にあらず";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MonicaCatalanoAndKristenBreshears;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

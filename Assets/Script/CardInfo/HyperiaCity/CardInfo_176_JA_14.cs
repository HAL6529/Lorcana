using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_14 : CardInfo
{
    public CardInfo_176_JA_14()
    {
        this.cardNo = "176_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ティアナ";
        this.cardName2 = "レストランの経営者";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

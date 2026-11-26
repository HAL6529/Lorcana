using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_14 : CardInfo
{
    public CardInfo_222_JA_14()
    {
        this.cardNo = "222_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "フラッシュ";
        this.cardName2 = "最速の職員";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_14 : CardInfo
{
    public CardInfo_069_JA_14()
    {
        this.cardNo = "069_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "トラスティ";
        this.cardName2 = "座席にご満悦";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_02 : CardInfo
{
    public CardInfo_079_JA_02()
    {
        this.cardNo = "079_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ファシリエ";
        this.cardName2 = "占い師";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_13 : CardInfo
{
    public CardInfo_079_JA_13()
    {
        this.cardNo = "079_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラッセル";
        this.cardName2 = "シニア自然探険隊員";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

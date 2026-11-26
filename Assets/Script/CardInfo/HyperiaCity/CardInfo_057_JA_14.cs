using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_14 : CardInfo
{
    public CardInfo_057_JA_14()
    {
        this.cardNo = "057_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "マーリン";
        this.cardName2 = "底なしの好奇心";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Gwawi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_04 : CardInfo
{
    public CardInfo_191_JA_04()
    {
        this.cardNo = "191_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ピグレット";
        this.cardName2 = "屈強な剣士";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

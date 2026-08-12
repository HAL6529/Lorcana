using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_01 : CardInfo
{
    public CardInfo_037_JA_01()
    {
        this.cardNo = "037_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ファシリエ";
        this.cardName2 = "悪事の協力者";
        this.power = 4;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = "Isaiah Mesq";
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

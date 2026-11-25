using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_13 : CardInfo
{
    public CardInfo_091_JA_13()
    {
        this.cardNo = "091_JA_13";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ポージー";
        this.cardName2 = "ヴァンパイモ";
        this.power = 7;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.PotatoShift5 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

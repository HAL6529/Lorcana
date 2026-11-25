using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_13 : CardInfo
{
    public CardInfo_074_JA_13()
    {
        this.cardNo = "074_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "カール･フレドリクセン";
        this.cardName2 = "愛する夫";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

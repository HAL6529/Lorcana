using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_13 : CardInfo
{
    public CardInfo_113_JA_13()
    {
        this.cardNo = "113_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "カール･フレドリクセン";
        this.cardName2 = "空飛ぶじいさん";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RodrigoCamilo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

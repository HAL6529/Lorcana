using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_13 : CardInfo
{
    public CardInfo_128_JA_13()
    {
        this.cardNo = "128_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "サリー";
        this.cardName2 = "子守りモンスター";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneTentoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors>();
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

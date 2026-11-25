using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_13 : CardInfo
{
    public CardInfo_048_JA_13()
    {
        this.cardNo = "048_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ペイン";
        this.cardName2 = "チョキチョキ使い魔";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BriannaGarcia;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

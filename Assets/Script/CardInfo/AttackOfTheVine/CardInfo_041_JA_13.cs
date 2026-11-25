using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_13 : CardInfo
{
    public CardInfo_041_JA_13()
    {
        this.cardNo = "041_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "パニック";
        this.cardName2 = "ドカドカ使い魔";
        this.power = 3;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BriannaGarcia;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

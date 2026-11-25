using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_13 : CardInfo
{
    public CardInfo_024_JA_13()
    {
        this.cardNo = "024_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "サリー";
        this.cardName2 = "新社長";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AnnaStosik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

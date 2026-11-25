using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_13 : CardInfo
{
    public CardInfo_001_JA_13()
    {
        this.cardNo = "001_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ウッディ";
        this.cardName2 = "俺が助けるぜ！";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

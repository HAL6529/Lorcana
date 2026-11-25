using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_13 : CardInfo
{
    public CardInfo_013_JA_13()
    {
        this.cardNo = "013_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ウッディ";
        this.cardName2 = "町の保安官";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

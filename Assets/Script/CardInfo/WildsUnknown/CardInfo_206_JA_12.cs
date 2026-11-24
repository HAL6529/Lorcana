using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_206_JA_12 : CardInfo
{
    public CardInfo_206_JA_12()
    {
        this.cardNo = "206_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "レックス";
        this.cardName2 = "カバウノサウルス";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Dinosaur, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

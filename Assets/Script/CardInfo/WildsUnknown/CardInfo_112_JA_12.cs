using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_12 : CardInfo
{
    public CardInfo_112_JA_12()
    {
        this.cardNo = "112_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ネジ巻きフロッグ";
        this.cardName2 = "シドのおもちゃ";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

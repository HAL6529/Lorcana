using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_12 : CardInfo
{
    public CardInfo_113_JA_12()
    {
        this.cardNo = "113_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ローラー・ボブ";
        this.cardName2 = "シドのおもちゃ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

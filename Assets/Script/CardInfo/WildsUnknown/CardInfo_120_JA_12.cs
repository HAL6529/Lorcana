using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_12 : CardInfo
{
    public CardInfo_120_JA_12()
    {
        this.cardNo = "120_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ガーガー";
        this.cardName2 = "シドのおもちゃ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

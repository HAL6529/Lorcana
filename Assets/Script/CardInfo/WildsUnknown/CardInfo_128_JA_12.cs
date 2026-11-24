using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_12 : CardInfo
{
    public CardInfo_128_JA_12()
    {
        this.cardNo = "128_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミュータント・ジェイニー";
        this.cardName2 = "シドのおもちゃ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

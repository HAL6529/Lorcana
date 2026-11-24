using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_12 : CardInfo
{
    public CardInfo_083_JA_12()
    {
        this.cardNo = "083_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "リトル・グリーン・メン";
        this.cardName2 = "ココロカラシンジルモノ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

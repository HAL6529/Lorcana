using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_12 : CardInfo
{
    public CardInfo_015_JA_12()
    {
        this.cardNo = "015_JA_12";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ウッディ";
        this.cardName2 = "ジャングルの案内人";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_14 : CardInfo
{
    public CardInfo_036_JA_14()
    {
        this.cardNo = "036_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スカットル";
        this.cardName2 = "交通整理係";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JustinRunfola;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

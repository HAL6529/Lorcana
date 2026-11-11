using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_05 : CardInfo
{
    public CardInfo_036_JA_05()
    {
        this.cardNo = "036_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ノック";
        this.cardName2 = "神話の精霊";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

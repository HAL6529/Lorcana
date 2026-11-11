using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_05 : CardInfo
{
    public CardInfo_077_JA_05()
    {
        this.cardNo = "077_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "弓術大会の選手";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

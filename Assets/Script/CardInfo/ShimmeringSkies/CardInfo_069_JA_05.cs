using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_05 : CardInfo
{
    public CardInfo_069_JA_05()
    {
        this.cardNo = "069_JA_05";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "機を見た乱入者";
        this.power = 6;
        this.toughness = 6;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.JamesReySanchez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

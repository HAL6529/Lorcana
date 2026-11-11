using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_05 : CardInfo
{
    public CardInfo_014_JA_05()
    {
        this.cardNo = "014_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "家族をつなぐもの";
        this.power = 5;
        this.toughness = 5;
        this.lore = 5;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

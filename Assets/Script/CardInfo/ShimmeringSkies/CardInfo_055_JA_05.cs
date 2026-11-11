using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_05 : CardInfo
{
    public CardInfo_055_JA_05()
    {
        this.cardNo = "055_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ラフィキ";
        this.cardName2 = "決闘シャーマン";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

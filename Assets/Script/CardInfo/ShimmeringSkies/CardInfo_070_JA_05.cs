using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_05 : CardInfo
{
    public CardInfo_070_JA_05()
    {
        this.cardNo = "070_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "シェンジ";
        this.cardName2 = "スカーの共犯者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulienVandols;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

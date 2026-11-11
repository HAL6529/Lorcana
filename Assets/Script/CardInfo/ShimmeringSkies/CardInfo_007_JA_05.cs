using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_05 : CardInfo
{
    public CardInfo_007_JA_05()
    {
        this.cardNo = "007_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "トゥーク";
        this.cardName2 = "ヘラジカ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

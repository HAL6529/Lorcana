using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_05 : CardInfo
{
    public CardInfo_083_JA_05()
    {
        this.cardNo = "083_JA_05";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "フィリップ王子";
        this.cardName2 = "国一番の剣士";
        this.power = 3;
        this.toughness = 9;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

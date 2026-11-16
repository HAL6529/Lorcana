using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_06 : CardInfo
{
    public CardInfo_083_JA_06()
    {
        this.cardNo = "083_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フィリップ王子";
        this.cardName2 = "高貴なる探検家";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

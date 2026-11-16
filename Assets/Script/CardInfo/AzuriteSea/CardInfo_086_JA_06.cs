using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_06 : CardInfo
{
    public CardInfo_086_JA_06()
    {
        this.cardNo = "086_JA_06";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "ベビゴッド";
        this.power = 6;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

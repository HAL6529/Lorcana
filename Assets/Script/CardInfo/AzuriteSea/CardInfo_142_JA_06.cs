using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_06 : CardInfo
{
    public CardInfo_142_JA_06()
    {
        this.cardNo = "142_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "オズワルド";
        this.cardName2 = "ザ・ラッキー・ラビット";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.TomBancroftAndKristenBreshears;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.OswaldTheLuckyRabbit;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

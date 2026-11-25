using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_13 : CardInfo
{
    public CardInfo_097_JA_13()
    {
        this.cardNo = "097_JA_13";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ムーシュー";
        this.cardName2 = "姑息な龍";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TomBancroftAndKristenBreshears;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

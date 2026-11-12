using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_07 : CardInfo
{
    public CardInfo_066_JA_07()
    {
        this.cardNo = "066_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "性悪なワタリガラス";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_01 : CardInfo
{
    public CardInfo_016_JA_01()
    {
        this.cardNo = "016_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "フィリップ王子";
        this.cardName2 = "ドラゴンに挑む者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Philipp Kruse";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

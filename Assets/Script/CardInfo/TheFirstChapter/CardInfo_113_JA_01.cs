using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_01 : CardInfo
{
    public CardInfo_113_JA_01()
    {
        this.cardNo = "113_JA_01";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "怪物ドラゴン";
        this.power = 7;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Luis Huerta";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

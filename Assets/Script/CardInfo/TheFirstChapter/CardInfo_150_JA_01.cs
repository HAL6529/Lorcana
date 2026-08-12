using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_01 : CardInfo
{
    public CardInfo_150_JA_01()
    {
        this.cardNo = "150_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "不吉な来訪者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

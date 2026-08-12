using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_01 : CardInfo
{
    public CardInfo_049_JA_01()
    {
        this.cardNo = "049_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "魔女";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Valerio Buonfantino";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

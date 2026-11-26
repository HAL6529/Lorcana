using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_14 : CardInfo
{
    public CardInfo_091_JA_14()
    {
        this.cardNo = "091_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フレッド";
        this.cardName2 = "怪獣大強襲！";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

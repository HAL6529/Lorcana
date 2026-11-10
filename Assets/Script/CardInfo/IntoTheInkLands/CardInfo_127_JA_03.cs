using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_03 : CardInfo
{
    public CardInfo_127_JA_03()
    {
        this.cardNo = "127_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ウェビー・ヴァンダークワック";
        this.cardName2 = "勝ち気なアヒルっ娘";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LouisJones;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

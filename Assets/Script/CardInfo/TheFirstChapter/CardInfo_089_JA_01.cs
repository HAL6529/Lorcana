using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_01 : CardInfo
{
    public CardInfo_089_JA_01()
    {
        this.cardNo = "089_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "蒸気船の操舵手";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Juan Diago Leon";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

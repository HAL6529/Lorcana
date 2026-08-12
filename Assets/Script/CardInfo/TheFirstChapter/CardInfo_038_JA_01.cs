using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_01 : CardInfo
{
    public CardInfo_038_JA_01()
    {
        this.cardNo = "038_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ファシリエ";
        this.cardName2 = "イカサマ師";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Grace Tran";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

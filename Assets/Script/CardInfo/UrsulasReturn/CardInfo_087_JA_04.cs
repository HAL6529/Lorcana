using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_04 : CardInfo
{
    public CardInfo_087_JA_04()
    {
        this.cardNo = "087_JA_04";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "フィリップ王子";
        this.cardName2 = "敵を打ち破る者";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

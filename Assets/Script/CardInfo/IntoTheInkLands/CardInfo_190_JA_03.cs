using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_03 : CardInfo
{
    public CardInfo_190_JA_03()
    {
        this.cardNo = "190_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "シャーウッドの英雄";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

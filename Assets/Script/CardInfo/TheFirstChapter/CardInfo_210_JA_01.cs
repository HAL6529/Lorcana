using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_210_JA_01 : CardInfo
{
    public CardInfo_210_JA_01()
    {
        this.cardNo = "210_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "腕利きの盗賊";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlexAccorsiAndKendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}

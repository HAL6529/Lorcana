using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_01 : CardInfo
{
    public CardInfo_139_JA_01()
    {
        this.cardNo = "139_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉIÅ[ÉçÉâ";
        this.cardName2 = "ñ≤å©ÇÈéÁåÏé“";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

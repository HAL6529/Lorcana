using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_214_JA_12 : CardInfo
{
    public CardInfo_214_JA_12()
    {
        this.cardNo = "214_JA_12";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ライル・ティベリウス・ローク";
        this.cardName2 = "硬化つな司令官";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxGrecke;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

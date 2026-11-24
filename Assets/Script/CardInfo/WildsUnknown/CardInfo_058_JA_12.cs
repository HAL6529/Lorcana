using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_12 : CardInfo
{
    public CardInfo_058_JA_12()
    {
        this.cardNo = "058_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アルマ・マドリガル";
        this.cardName2 = "魔法のともしびの守り手";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

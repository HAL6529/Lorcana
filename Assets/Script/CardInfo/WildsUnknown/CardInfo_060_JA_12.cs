using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_12 : CardInfo
{
    public CardInfo_060_JA_12()
    {
        this.cardNo = "060_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ルイーサ・マドリガル";
        this.cardName2 = "自信家の登山家";
        this.power = 6;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

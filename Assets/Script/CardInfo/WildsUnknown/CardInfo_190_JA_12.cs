using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_12 : CardInfo
{
    public CardInfo_190_JA_12()
    {
        this.cardNo = "190_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "オムニドロイド";
        this.cardName2 = "10世";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

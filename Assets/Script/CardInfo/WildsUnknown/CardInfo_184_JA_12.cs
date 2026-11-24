using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_12 : CardInfo
{
    public CardInfo_184_JA_12()
    {
        this.cardNo = "184_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "オムニドロイド";
        this.cardName2 = "9世";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

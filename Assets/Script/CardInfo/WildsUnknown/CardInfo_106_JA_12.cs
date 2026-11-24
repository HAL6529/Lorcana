using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_12 : CardInfo
{
    public CardInfo_106_JA_12()
    {
        this.cardNo = "106_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ペガサス";
        this.cardName2 = "天地を駆ける探索者";
        this.power = 6;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

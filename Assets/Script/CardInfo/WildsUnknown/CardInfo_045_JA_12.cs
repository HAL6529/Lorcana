using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_12 : CardInfo
{
    public CardInfo_045_JA_12()
    {
        this.cardNo = "045_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アルマ・マドリガル";
        this.cardName2 = "家族の中心";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MagentaMuraca;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

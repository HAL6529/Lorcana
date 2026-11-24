using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_12 : CardInfo
{
    public CardInfo_036_JA_12()
    {
        this.cardNo = "036_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アルマ・マドリガル";
        this.cardName2 = "新天地を目指して";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_02 : CardInfo
{
    public CardInfo_036_JA_02()
    {
        this.cardNo = "036_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ブルー・フェアリー";
        this.cardName2 = "良い行いに報いる者";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KierstenHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

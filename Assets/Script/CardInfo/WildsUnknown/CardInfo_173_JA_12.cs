using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_12 : CardInfo
{
    public CardInfo_173_JA_12()
    {
        this.cardNo = "173_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "オムニドロイド";
        this.cardName2 = "8世";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

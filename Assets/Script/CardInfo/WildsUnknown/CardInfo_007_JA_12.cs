using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_12 : CardInfo
{
    public CardInfo_007_JA_12()
    {
        this.cardNo = "007_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アラナデール";
        this.cardName2 = "義理堅い吟遊詩人";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BillyMartin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

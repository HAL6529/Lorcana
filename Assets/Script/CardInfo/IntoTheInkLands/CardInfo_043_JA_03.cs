using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_03 : CardInfo
{
    public CardInfo_043_JA_03()
    {
        this.cardNo = "043_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "リナ・セイブルウィング";
        this.cardName2 = "反抗的ティーンエイジャー";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

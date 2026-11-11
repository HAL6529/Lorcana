using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_05 : CardInfo
{
    public CardInfo_176_JA_05()
    {
        this.cardNo = "176_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "守備的フードファイター";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

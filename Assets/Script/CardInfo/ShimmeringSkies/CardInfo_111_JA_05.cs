using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_05 : CardInfo
{
    public CardInfo_111_JA_05()
    {
        this.cardNo = "111_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "パイ避け名人";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaddieShilt;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

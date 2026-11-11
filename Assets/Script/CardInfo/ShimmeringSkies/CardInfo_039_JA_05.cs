using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_05 : CardInfo
{
    public CardInfo_039_JA_05()
    {
        this.cardNo = "039_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "イラ立ちフクロウ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

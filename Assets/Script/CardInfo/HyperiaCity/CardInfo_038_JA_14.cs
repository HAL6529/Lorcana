using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_14 : CardInfo
{
    public CardInfo_038_JA_14()
    {
        this.cardNo = "038_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "レキシントン";
        this.cardName2 = "恐れ知らずの滑空者";
        this.power = 3;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

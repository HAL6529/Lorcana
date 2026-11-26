using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_14 : CardInfo
{
    public CardInfo_048_JA_14()
    {
        this.cardNo = "048_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ダンテ";
        this.cardName2 = "かわいい変わり者";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JamesReySanchez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

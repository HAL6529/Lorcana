using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_12 : CardInfo
{
    public CardInfo_048_JA_12()
    {
        this.cardNo = "048_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヴァイオレット・パー";
        this.cardName2 = "新たなパワーの練習中";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

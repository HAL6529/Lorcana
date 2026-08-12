using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_01 : CardInfo
{
    public CardInfo_043_JA_01()
    {
        this.cardNo = "043_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "フロットサム";
        this.cardName2 = "アースラのスパイ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Luis Huerta";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_01 : CardInfo
{
    public CardInfo_046_JA_01()
    {
        this.cardNo = "046_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジェットサム";
        this.cardName2 = "アースラのスパイ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Brian Weisz";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

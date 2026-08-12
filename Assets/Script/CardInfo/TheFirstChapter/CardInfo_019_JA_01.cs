using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_01 : CardInfo
{
    public CardInfo_019_JA_01()
    {
        this.cardNo = "019_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "セバスチャン";
        this.cardName2 = "宮廷作曲家";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Isaiah Mesq";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

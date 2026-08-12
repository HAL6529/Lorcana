using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_01 : CardInfo
{
    public CardInfo_002_JA_01()
    {
        this.cardNo = "002_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒAƒŠƒGƒ‹";
        this.cardName2 = "—í‚µ‚¢‰Ì•P";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Alice Pisoni";
        this.classList = new List<EnumController.Class> { EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.StoryBorn};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

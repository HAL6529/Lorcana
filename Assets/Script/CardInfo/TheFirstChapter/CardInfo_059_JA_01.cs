using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_01 : CardInfo
{
    public CardInfo_059_JA_01()
    {
        this.cardNo = "059_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "アースラ";
        this.cardName2 = "パワーをちょうだい!";
        this.power = 2;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = "Simangaliso Sibaya";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

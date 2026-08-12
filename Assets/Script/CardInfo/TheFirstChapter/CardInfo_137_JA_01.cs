using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_01 : CardInfo
{
    public CardInfo_137_JA_01()
    {
        this.cardNo = "137_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "アリエル";
        this.cardName2 = "沈品収集家";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Hedving Haggman-Sund";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

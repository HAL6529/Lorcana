using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_01 : CardInfo
{
    public CardInfo_082_JA_01()
    {
        this.cardNo = "082_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ジョン・シルバー";
        this.cardName2 = "宇宙海賊";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Jared Nickerl";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_03 : CardInfo
{
    public CardInfo_122_JA_03()
    {
        this.cardNo = "122_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スクループ";
        this.cardName2 = "卑怯者";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_211_JA_03 : CardInfo
{
    public CardInfo_211_JA_03()
    {
        this.cardNo = "211_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "モーフ";
        this.cardName2 = "宇宙スライム";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}

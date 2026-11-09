using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_03 : CardInfo
{
    public CardInfo_104_JA_03()
    {
        this.cardNo = "104_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ビリー・ボーンズ";
        this.cardName2 = "地図の所持者";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RogerPerez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Pirate};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

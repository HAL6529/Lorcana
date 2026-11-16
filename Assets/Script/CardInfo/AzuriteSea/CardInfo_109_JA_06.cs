using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_06 : CardInfo
{
    public CardInfo_109_JA_06()
    {
        this.cardNo = "109_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ジョン・シルバー";
        this.cardName2 = "獰猛なる友";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

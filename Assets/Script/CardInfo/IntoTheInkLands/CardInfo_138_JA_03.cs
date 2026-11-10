using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_03 : CardInfo
{
    public CardInfo_138_JA_03()
    {
        this.cardNo = "138_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アメリア船長";
        this.cardName2 = "総指揮官";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_06 : CardInfo
{
    public CardInfo_181_JA_06()
    {
        this.cardNo = "181_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジョン・シルバー";
        this.cardName2 = "船のコック";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_06 : CardInfo
{
    public CardInfo_192_JA_06()
    {
        this.cardNo = "192_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アメリア船長";
        this.cardName2 = "レガシーの指揮官";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien, EnumController.Class.Captain};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

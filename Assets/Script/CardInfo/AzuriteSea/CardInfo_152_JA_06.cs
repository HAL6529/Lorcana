using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_06 : CardInfo
{
    public CardInfo_152_JA_06()
    {
        this.cardNo = "152_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デルバート・ドップラー博士";
        this.cardName2 = "せわしない天文学者";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

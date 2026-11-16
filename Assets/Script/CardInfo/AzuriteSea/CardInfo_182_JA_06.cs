using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_06 : CardInfo
{
    public CardInfo_182_JA_06()
    {
        this.cardNo = "182_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミスター・アロー";
        this.cardName2 = "レガシーの一等航海士";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MichelaCacciatoreAndGiuliaPriori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

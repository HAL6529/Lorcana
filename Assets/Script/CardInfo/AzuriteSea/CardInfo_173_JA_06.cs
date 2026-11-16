using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_06 : CardInfo
{
    public CardInfo_173_JA_06()
    {
        this.cardNo = "173_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジム・ホーキンス";
        this.cardName2 = "負けず嫌いな見習い";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.UrsulaDorada;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

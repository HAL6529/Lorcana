using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_06 : CardInfo
{
    public CardInfo_025_JA_06()
    {
        this.cardNo = "025_JA_06";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ジム・ホーキンス";
        this.cardName2 = "高潔なる海賊";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

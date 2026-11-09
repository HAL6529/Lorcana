using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_03 : CardInfo
{
    public CardInfo_109_JA_03()
    {
        this.cardNo = "109_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジム・ホーキンス";
        this.cardName2 = "宇宙の旅人";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

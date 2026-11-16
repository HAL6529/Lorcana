using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_06 : CardInfo
{
    public CardInfo_183_JA_06()
    {
        this.cardNo = "183_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ジム・ホーキンス";
        this.cardName2 = "索具の専門家";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OrnellaSavarese;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_06 : CardInfo
{
    public CardInfo_222_JA_06()
    {
        this.cardNo = "222_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "トレジャー・マウンテン";
        this.cardName2 = "アズライト海の島";
        this.power = 2;
        this.toughness = 9;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SamNielson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Enchanted;
    }
}

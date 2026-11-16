using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_06 : CardInfo
{
    public CardInfo_132_JA_06()
    {
        this.cardNo = "132_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ロングボート";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlexShin;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

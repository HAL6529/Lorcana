using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_06 : CardInfo
{
    public CardInfo_169_JA_06()
    {
        this.cardNo = "169_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "レスキュー・レンジャーの潜水艦";
        this.cardName2 = "移動司令部";
        this.power = 1;
        this.toughness = 8;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.GeoffreyBoudout;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

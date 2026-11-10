using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_03 : CardInfo
{
    public CardInfo_101_JA_03()
    {
        this.cardNo = "101_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉtÉ@ÉìÉO";
        this.cardName2 = "êÏÇÃìsés";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MichaelGuimont;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_05 : CardInfo
{
    public CardInfo_203_JA_05()
    {
        this.cardNo = "203_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "悪役お悩み相談会";
        this.cardName2 = "ヴィランズ支援センター";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

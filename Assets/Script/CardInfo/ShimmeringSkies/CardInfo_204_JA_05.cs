using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_05 : CardInfo
{
    public CardInfo_204_JA_05()
    {
        this.cardNo = "204_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÇVêlÇÃÇ±Ç—Ç∆ÇÃçzéR";
        this.cardName2 = "åòòSÇ»ÇÈóvç«";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexaRockman;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

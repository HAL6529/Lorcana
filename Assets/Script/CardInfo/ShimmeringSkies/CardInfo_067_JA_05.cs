using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_05 : CardInfo
{
    public CardInfo_067_JA_05()
    {
        this.cardNo = "067_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉGÉãÉTÇÃïXÇÃã{ìa";
        this.cardName2 = "å«ì∆ÇÃèZèà";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

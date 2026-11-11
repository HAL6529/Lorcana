using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_05 : CardInfo
{
    public CardInfo_128_JA_05()
    {
        this.cardNo = "128_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ˆ«ŽÒ‚Í—pˆÓŽü“ž";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AdamBunch;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_05 : CardInfo
{
    public CardInfo_026_JA_05()
    {
        this.cardNo = "026_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "–ü‚µ‚ÌŽè";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_05 : CardInfo
{
    public CardInfo_030_JA_05()
    {
        this.cardNo = "030_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "–ü‚µ‚ÌƒfƒJƒ“ƒ^";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

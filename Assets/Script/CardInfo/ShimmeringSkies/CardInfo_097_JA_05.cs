using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_05 : CardInfo
{
    public CardInfo_097_JA_05()
    {
        this.cardNo = "097_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "思い出せ、お前が誰か";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CoryGodbey;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

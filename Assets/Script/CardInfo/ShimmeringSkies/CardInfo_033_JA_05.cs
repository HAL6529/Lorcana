using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_05 : CardInfo
{
    public CardInfo_033_JA_05()
    {
        this.cardNo = "033_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ラプンツェルの塔";
        this.cardName2 = "人里離れた監獄";
        this.power = 1;
        this.toughness = 8;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

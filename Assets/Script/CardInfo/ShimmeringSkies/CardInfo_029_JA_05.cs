using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_05 : CardInfo
{
    public CardInfo_029_JA_05()
    {
        this.cardNo = "029_JA_05";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ïëì•âÔÇ÷ÇÃèµë“";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Taraneh;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

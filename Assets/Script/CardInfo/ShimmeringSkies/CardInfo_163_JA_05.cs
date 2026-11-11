using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_05 : CardInfo
{
    public CardInfo_163_JA_05()
    {
        this.cardNo = "163_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "âBÇ∑Ç»ÇÁêXÇÃíÜ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

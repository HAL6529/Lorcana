using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_05 : CardInfo
{
    public CardInfo_164_JA_05()
    {
        this.cardNo = "164_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "Ç±ÇÍà»è„ÇÕåãç\";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AdamFord;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

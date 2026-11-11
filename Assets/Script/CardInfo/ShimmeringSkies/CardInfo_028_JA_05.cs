using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_05 : CardInfo
{
    public CardInfo_028_JA_05()
    {
        this.cardNo = "028_JA_05";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "‰»‚¯‚Ì”ç‚Í‚ª‚µ‚Ä‚â‚é";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.SuperRare;
    }
}

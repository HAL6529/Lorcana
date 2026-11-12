using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_07 : CardInfo
{
    public CardInfo_082_JA_07()
    {
        this.cardNo = "082_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "Ç‡Ç¡Ç∆Ç®å©ÇπÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NatalieDombois;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.SuperRare;
    }
}

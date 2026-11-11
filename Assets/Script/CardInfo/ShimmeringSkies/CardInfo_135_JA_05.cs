using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_05 : CardInfo
{
    public CardInfo_135_JA_05()
    {
        this.cardNo = "135_JA_05";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "シュガーラッシュスピードウェイ";
        this.cardName2 = "スタートライン";
        this.power = 0;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

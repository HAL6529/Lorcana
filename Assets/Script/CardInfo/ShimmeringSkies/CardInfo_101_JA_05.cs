using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_05 : CardInfo
{
    public CardInfo_101_JA_05()
    {
        this.cardNo = "101_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "シャーウッドの森";
        this.cardName2 = "お尋ね者の隠れ家";
        this.power = 2;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.DouglasDeLaHoz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

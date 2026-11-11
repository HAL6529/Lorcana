using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_05 : CardInfo
{
    public CardInfo_136_JA_05()
    {
        this.cardNo = "136_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ラティガンのパーティー";
        this.cardName2 = "薄汚い裏部屋";
        this.power = 1;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_05 : CardInfo
{
    public CardInfo_025_JA_05()
    {
        this.cardNo = "025_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "Try Everything";
        this.cardName2 = "トライ・エヴリシング";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

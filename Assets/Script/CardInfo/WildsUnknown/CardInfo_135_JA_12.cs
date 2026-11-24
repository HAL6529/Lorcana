using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_12 : CardInfo
{
    public CardInfo_135_JA_12()
    {
        this.cardNo = "135_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "インクランド辺境";
        this.cardName2 = "砂漠の遺跡";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

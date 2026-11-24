using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_12 : CardInfo
{
    public CardInfo_204_JA_12()
    {
        this.cardNo = "204_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ノマニザン島";
        this.cardName2 = "シンドロームの秘密基地";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

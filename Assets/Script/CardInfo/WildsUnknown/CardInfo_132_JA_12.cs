using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_12 : CardInfo
{
    public CardInfo_132_JA_12()
    {
        this.cardNo = "132_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヒーロー活動";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

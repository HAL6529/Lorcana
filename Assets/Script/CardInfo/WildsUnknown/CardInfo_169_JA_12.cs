using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_12 : CardInfo
{
    public CardInfo_169_JA_12()
    {
        this.cardNo = "169_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "羊飼いの日誌";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IsabellaCeravolo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

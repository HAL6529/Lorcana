using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_06 : CardInfo
{
    public CardInfo_098_JA_06()
    {
        this.cardNo = "098_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ÉÅÉKÉ{ÉbÉg";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

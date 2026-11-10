using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_03 : CardInfo
{
    public CardInfo_167_JA_03()
    {
        this.cardNo = "167_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "‹àŒÉ‚Ì”à";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

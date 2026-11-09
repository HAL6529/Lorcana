using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_03 : CardInfo
{
    public CardInfo_169_JA_03()
    {
        this.cardNo = "169_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マクダック邸";
        this.cardName2 = "スクルージの屋敷";
        this.power = 1;
        this.toughness = 9;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

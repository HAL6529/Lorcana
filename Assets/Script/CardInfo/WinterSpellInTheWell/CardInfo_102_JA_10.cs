using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_10 : CardInfo
{
    public CardInfo_102_JA_10()
    {
        this.cardNo = "102_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ホワイトアゴニー平原";
        this.cardName2 = "黄金の沼";
        this.power = 1;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.MaximilienBorie;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

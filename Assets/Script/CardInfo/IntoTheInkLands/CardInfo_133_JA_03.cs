using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_03 : CardInfo
{
    public CardInfo_133_JA_03()
    {
        this.cardNo = "133_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "シュメールのタリスマン";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AdamBunch;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

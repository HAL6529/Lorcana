using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_03 : CardInfo
{
    public CardInfo_097_JA_03()
    {
        this.cardNo = "097_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スカイボード";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

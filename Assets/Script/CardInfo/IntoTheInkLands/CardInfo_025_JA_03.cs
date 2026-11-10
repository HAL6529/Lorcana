using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_03 : CardInfo
{
    public CardInfo_025_JA_03()
    {
        this.cardNo = "025_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "É{ÉXÇÃñΩóﬂ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ZuzanaSokolovaAndLivioCacciatore;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_03 : CardInfo
{
    public CardInfo_198_JA_03()
    {
        this.cardNo = "198_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "É^ÉCÉ^ÉìÇÃêÌÇ¢";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

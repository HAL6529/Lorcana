using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_099_JA_04 : CardInfo
{
    public CardInfo_099_JA_04()
    {
        this.cardNo = "099_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉTÉCÉìÇ≥ÇÍÇΩå_ñÒèë";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndrewPena;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

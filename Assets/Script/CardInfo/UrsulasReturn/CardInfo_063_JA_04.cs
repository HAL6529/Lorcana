using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_063_JA_04 : CardInfo
{
    public CardInfo_063_JA_04()
    {
        this.cardNo = "063_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アースラの計画";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

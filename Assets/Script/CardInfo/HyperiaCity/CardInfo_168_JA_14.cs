using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_14 : CardInfo
{
    public CardInfo_168_JA_14()
    {
        this.cardNo = "168_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "帽遠鏡";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.XaviPlanasTorrents;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

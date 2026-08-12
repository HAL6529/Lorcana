using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_01 : CardInfo
{
    public CardInfo_067_JA_01()
    {
        this.cardNo = "067_JA_01";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ÉAÅ[ÉXÉâÇÃëÂäò";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Oleg Yurkov";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_01 : CardInfo
{
    public CardInfo_168_JA_01()
    {
        this.cardNo = "168_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ãõÇÃçúÉyÉì";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Tanisha Cherislin";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

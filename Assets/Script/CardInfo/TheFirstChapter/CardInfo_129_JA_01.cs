using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_01 : CardInfo
{
    public CardInfo_129_JA_01()
    {
        this.cardNo = "129_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "íPìÅíºì¸";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Ellie Horie";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

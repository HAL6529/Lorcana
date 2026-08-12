using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_01 : CardInfo
{
    public CardInfo_203_JA_01()
    {
        this.cardNo = "203_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "銃士のタバード";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Dav Augereau";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

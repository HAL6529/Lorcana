using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_04 : CardInfo
{
    public CardInfo_093_JA_04()
    {
        this.cardNo = "093_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Ç–ÇÁÇËÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

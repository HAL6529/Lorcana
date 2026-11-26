using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_14 : CardInfo
{
    public CardInfo_199_JA_14()
    {
        this.cardNo = "199_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "カーン航空便";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

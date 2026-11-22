using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_10 : CardInfo
{
    public CardInfo_133_JA_10()
    {
        this.cardNo = "133_JA_10";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ドラゴンの炎";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DavidOtaloraAndXaviPlanas;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

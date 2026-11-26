using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_14 : CardInfo
{
    public CardInfo_130_JA_14()
    {
        this.cardNo = "130_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "最高に…";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

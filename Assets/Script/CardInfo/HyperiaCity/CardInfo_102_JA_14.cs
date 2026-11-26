using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_14 : CardInfo
{
    public CardInfo_102_JA_14()
    {
        this.cardNo = "102_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "豆の木";
        this.cardName2 = "どんどん上へ伸び続けた！";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlyssaLee;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_12 : CardInfo
{
    public CardInfo_130_JA_12()
    {
        this.cardNo = "130_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ホタルの大群";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> ();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

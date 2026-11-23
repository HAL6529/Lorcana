using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_11 : CardInfo
{
    public CardInfo_102_JA_11()
    {
        this.cardNo = "102_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "禁猟区";
        this.cardName2 = "護られた土地";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DouglasDeLaHoz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

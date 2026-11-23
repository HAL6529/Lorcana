using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_11 : CardInfo
{
    public CardInfo_034_JA_11()
    {
        this.cardNo = "034_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ズートピア";
        this.cardName2 = "ツンドラ・タウン";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

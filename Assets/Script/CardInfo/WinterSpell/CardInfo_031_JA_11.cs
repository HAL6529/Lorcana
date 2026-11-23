using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_031_JA_11 : CardInfo
{
    public CardInfo_031_JA_11()
    {
        this.cardNo = "031_JA_11";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "おばあさんの知恵袋";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

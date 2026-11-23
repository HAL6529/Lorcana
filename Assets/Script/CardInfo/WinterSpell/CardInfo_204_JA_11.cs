using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_11 : CardInfo
{
    public CardInfo_204_JA_11()
    {
        this.cardNo = "204_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・タワー";
        this.cardName2 = "";
        this.power = 1;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SergioMancinelli;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

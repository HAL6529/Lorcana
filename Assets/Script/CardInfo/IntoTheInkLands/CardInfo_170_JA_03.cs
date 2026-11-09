using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_03 : CardInfo
{
    public CardInfo_170_JA_03()
    {
        this.cardNo = "170_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒ‚ƒgƒDƒkƒC";
        this.cardName2 = "Šy‰€‚Ì“‡";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EtienneSavoie;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_03 : CardInfo
{
    public CardInfo_202_JA_03()
    {
        this.cardNo = "202_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒ}ƒEƒC‚Ì—¬ŒY“‡";
        this.cardName2 = "‰B‚³‚ê‚½“‡";
        this.power = 1;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

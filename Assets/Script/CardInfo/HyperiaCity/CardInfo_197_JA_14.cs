using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_197_JA_14 : CardInfo
{
    public CardInfo_197_JA_14()
    {
        this.cardNo = "197_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "馬上槍試合";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RosaLaBarberaAndLivioCacciatore;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

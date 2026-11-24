using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_12 : CardInfo
{
    public CardInfo_202_JA_12()
    {
        this.cardNo = "202_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "カジノのドア";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

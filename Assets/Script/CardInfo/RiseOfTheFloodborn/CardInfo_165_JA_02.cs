using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_165_JA_02 : CardInfo
{
    public CardInfo_165_JA_02()
    {
        this.cardNo = "165_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "‚¨Œ©’Ê‚µ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.M_K_Manderson_JochemVanGool;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

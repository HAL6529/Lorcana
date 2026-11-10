using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_04 : CardInfo
{
    public CardInfo_163_JA_04()
    {
        this.cardNo = "163_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "‘I‚è‚·‚®‚è";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

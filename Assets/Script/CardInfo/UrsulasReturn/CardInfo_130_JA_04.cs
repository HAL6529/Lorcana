using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_04 : CardInfo
{
    public CardInfo_130_JA_04()
    {
        this.cardNo = "130_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "óêì¨";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RosaLaBarberaAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

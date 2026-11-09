using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_04 : CardInfo
{
    public CardInfo_133_JA_04()
    {
        this.cardNo = "133_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "“n‚è”Â";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RobertoGatto;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

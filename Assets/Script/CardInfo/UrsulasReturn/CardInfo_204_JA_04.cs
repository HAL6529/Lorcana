using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_04 : CardInfo
{
    public CardInfo_204_JA_04()
    {
        this.cardNo = "204_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "テーベ";
        this.cardName2 = "ビッグ・オリーブ";
        this.power = 1;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

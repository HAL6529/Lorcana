using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_04 : CardInfo
{
    public CardInfo_067_JA_04()
    {
        this.cardNo = "067_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マドリガル家のおうち";
        this.cardName2 = "カシータ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

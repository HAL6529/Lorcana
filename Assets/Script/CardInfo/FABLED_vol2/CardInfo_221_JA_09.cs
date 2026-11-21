using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_221_JA_09 : CardInfo
{
    public CardInfo_221_JA_09()
    {
        this.cardNo = "221_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "旗持ち";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_04 : CardInfo
{
    public CardInfo_188_JA_04()
    {
        this.cardNo = "188_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "旗持ち";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

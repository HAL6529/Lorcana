using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_14 : CardInfo
{
    public CardInfo_092_JA_14()
    {
        this.cardNo = "092_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "大忙しのがんばり屋さん";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_14 : CardInfo
{
    public CardInfo_023_JA_14()
    {
        this.cardNo = "023_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "名物店主";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Adventurous };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

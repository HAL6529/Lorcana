using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_03 : CardInfo
{
    public CardInfo_182_JA_03()
    {
        this.cardNo = "182_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "ラッパ吹き";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_216_JA_11 : CardInfo
{
    public CardInfo_216_JA_11()
    {
        this.cardNo = "216_JA_11";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "グーフィー";
        this.cardName2 = "不器用スキーヤー";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LouisJones;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

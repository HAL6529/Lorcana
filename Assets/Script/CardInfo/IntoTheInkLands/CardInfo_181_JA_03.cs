using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_03 : CardInfo
{
    public CardInfo_181_JA_03()
    {
        this.cardNo = "181_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "勇敢な探検家";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LouisJones;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_06 : CardInfo
{
    public CardInfo_187_JA_06()
    {
        this.cardNo = "187_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "夜の見回り番";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigHaggman_Sund;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

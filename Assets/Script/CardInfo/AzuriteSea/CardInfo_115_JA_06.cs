using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_06 : CardInfo
{
    public CardInfo_115_JA_06()
    {
        this.cardNo = "115_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "勇敢な船員";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

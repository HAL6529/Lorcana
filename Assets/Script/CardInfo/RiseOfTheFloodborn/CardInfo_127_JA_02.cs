using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_02 : CardInfo
{
    public CardInfo_127_JA_02()
    {
        this.cardNo = "127_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉeÉBÉKÅ[";
        this.cardName2 = "ê¢äEÇ…Ç–Ç∆ÇË";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.P_GaylordAndL_Giammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Tigger };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

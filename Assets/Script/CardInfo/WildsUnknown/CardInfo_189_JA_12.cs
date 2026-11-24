using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_12 : CardInfo
{
    public CardInfo_189_JA_12()
    {
        this.cardNo = "189_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "グーフィー";
        this.cardName2 = "岩盤る旅人";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

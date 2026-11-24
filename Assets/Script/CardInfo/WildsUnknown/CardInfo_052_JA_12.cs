using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_12 : CardInfo
{
    public CardInfo_052_JA_12()
    {
        this.cardNo = "052_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "手慣れた旅人";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

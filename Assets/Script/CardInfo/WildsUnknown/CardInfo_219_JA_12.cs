using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_219_JA_12 : CardInfo
{
    public CardInfo_219_JA_12()
    {
        this.cardNo = "219_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "堅実な旅人";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

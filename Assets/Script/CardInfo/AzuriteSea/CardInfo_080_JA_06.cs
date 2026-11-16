using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_06 : CardInfo
{
    public CardInfo_080_JA_06()
    {
        this.cardNo = "080_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "一等航海士";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

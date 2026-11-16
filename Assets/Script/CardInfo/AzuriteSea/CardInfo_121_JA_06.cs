using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_06 : CardInfo
{
    public CardInfo_121_JA_06()
    {
        this.cardNo = "121_JA_06";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "モアナ";
        this.cardName2 = "カカモラのお頭";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaredMathews;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

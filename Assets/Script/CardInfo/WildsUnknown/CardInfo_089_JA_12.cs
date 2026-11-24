using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_12 : CardInfo
{
    public CardInfo_089_JA_12()
    {
        this.cardNo = "089_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "メリダ";
        this.cardName2 = "天性の射手";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

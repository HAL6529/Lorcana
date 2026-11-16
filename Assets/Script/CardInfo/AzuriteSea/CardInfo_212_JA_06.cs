using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_06 : CardInfo
{
    public CardInfo_212_JA_06()
    {
        this.cardNo = "212_JA_06";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉoÉWÉã";
        this.cardName2 = "íTí„ìÒè\ñ ëä";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JustinGerard;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_11 : CardInfo
{
    public CardInfo_047_JA_11()
    {
        this.cardNo = "047_JA_11";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "モルガナ・マカーバー";
        this.cardName2 = "改心した呪文使い";
        this.power = 6;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

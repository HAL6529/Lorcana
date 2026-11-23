using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_11 : CardInfo
{
    public CardInfo_147_JA_11()
    {
        this.cardNo = "147_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ピグレット";
        this.cardName2 = "ココア屋さん";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VanessaMorales;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

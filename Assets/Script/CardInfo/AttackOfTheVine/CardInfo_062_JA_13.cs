using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_13 : CardInfo
{
    public CardInfo_062_JA_13()
    {
        this.cardNo = "062_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "くまのプーさん＆ピグレット";
        this.cardName2 = "はちみつの魔術師たち";
        this.power = 3;
        this.toughness = 4;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Sorcerer, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

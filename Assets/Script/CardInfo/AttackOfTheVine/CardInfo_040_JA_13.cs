using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_13 : CardInfo
{
    public CardInfo_040_JA_13()
    {
        this.cardNo = "040_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "くまのプーさん";
        this.cardName2 = "はちみつの大魔術師";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_13 : CardInfo
{
    public CardInfo_154_JA_13()
    {
        this.cardNo = "154_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ピグレット";
        this.cardName2 = "はちみつの見習い魔術師";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MartaAndreeva;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Sorcerer, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

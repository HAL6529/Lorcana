using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_13 : CardInfo
{
    public CardInfo_042_JA_13()
    {
        this.cardNo = "042_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ランピー";
        this.cardName2 = "はちみつのドルイド";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

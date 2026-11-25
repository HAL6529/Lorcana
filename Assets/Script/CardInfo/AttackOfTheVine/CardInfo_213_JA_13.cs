using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_13 : CardInfo
{
    public CardInfo_213_JA_13()
    {
        this.cardNo = "213_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "Mrs.インクレディブル";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Super, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

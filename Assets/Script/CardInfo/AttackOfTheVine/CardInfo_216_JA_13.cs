using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_216_JA_13 : CardInfo
{
    public CardInfo_216_JA_13()
    {
        this.cardNo = "216_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SimoneGiovanardi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

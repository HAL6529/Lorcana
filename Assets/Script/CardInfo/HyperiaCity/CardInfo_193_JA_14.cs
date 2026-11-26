using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_14 : CardInfo
{
    public CardInfo_193_JA_14()
    {
        this.cardNo = "193_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "アーサー";
        this.cardName2 = "馬上槍試合の騎士";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Knight};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

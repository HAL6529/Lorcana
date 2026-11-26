using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_14 : CardInfo
{
    public CardInfo_086_JA_14()
    {
        this.cardNo = "086_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "フレッド";
        this.cardName2 = "イケてる若社長";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

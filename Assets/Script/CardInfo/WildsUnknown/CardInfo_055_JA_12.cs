using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_12 : CardInfo
{
    public CardInfo_055_JA_12()
    {
        this.cardNo = "055_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "横柄な旅人";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

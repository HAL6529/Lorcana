using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_14 : CardInfo
{
    public CardInfo_213_JA_14()
    {
        this.cardNo = "213_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "ラボのロボ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

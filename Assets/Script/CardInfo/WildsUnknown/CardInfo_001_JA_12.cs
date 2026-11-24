using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_12 : CardInfo
{
    public CardInfo_001_JA_12()
    {
        this.cardNo = "001_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ゴサリン・マラード";
        this.cardName2 = "クイバーウィング・クワック";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

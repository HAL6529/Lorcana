using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_14 : CardInfo
{
    public CardInfo_090_JA_14()
    {
        this.cardNo = "090_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "非凡な文筆家";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

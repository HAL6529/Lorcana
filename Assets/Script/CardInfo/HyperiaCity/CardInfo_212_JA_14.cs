using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_14 : CardInfo
{
    public CardInfo_212_JA_14()
    {
        this.cardNo = "212_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "回顧にひたる文筆家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

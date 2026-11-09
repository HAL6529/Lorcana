using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_04 : CardInfo
{
    public CardInfo_036_JA_04()
    {
        this.cardNo = "036_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "熟練なるミスティーク";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

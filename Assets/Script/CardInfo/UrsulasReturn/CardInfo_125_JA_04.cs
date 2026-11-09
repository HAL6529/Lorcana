using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_04 : CardInfo
{
    public CardInfo_125_JA_04()
    {
        this.cardNo = "125_JA_04";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "シスー";
        this.cardName2 = "兄弟姉妹の希望";
        this.power = 5;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

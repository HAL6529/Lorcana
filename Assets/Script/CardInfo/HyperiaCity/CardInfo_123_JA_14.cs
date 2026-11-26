using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_14 : CardInfo
{
    public CardInfo_123_JA_14()
    {
        this.cardNo = "123_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "メイ・リー";
        this.cardName2 = "めろめろファン";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrancescaRisoldi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

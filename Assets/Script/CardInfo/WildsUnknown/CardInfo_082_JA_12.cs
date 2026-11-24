using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_12 : CardInfo
{
    public CardInfo_082_JA_12()
    {
        this.cardNo = "082_JA_12";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "マイロ・サッチ";
        this.cardName2 = "現場主義";
        this.power = 5;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JohnLoren;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

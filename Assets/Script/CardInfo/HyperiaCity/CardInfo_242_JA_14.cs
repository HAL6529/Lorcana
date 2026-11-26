using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_242_JA_14 : CardInfo
{
    public CardInfo_242_JA_14()
    {
        this.cardNo = "242_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "シンデレラ";
        this.cardName2 = "ファッション界のシンデレラ";
        this.power = 4;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.ClioSchaffner;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Iconic;
    }
}

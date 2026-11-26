using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_14 : CardInfo
{
    public CardInfo_196_JA_14()
    {
        this.cardNo = "196_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ティアナ";
        this.cardName2 = "パーティーの主催者";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AristeidisZentelis;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

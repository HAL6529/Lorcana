using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_13 : CardInfo
{
    public CardInfo_187_JA_13()
    {
        this.cardNo = "187_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "正体不明のスーパーヒーロー";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LouisJones;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

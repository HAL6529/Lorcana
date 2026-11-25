using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_165_JA_13 : CardInfo
{
    public CardInfo_165_JA_13()
    {
        this.cardNo = "165_JA_13";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・ダック＆ランチパッド";
        this.cardName2 = "セントカナード最高の男たち";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

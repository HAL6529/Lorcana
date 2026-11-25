using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_13 : CardInfo
{
    public CardInfo_183_JA_13()
    {
        this.cardNo = "183_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヴァイオレット・パー";
        this.cardName2 = "バリア実践中";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

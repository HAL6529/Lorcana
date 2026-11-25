using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_13 : CardInfo
{
    public CardInfo_176_JA_13()
    {
        this.cardNo = "176_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ヴァイオレット・パー";
        this.cardName2 = "スーパーシールドガール";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

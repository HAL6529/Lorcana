using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_13 : CardInfo
{
    public CardInfo_133_JA_13()
    {
        this.cardNo = "133_JA_13";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ダッシュ・パー＆ヴァイオレット・パー";
        this.cardName2 = "スーパーキッズ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ComboShift6, EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

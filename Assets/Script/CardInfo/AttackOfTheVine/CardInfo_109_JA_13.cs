using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_13 : CardInfo
{
    public CardInfo_109_JA_13()
    {
        this.cardNo = "109_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ダッシュ・パー";
        this.cardName2 = "スーパースピードボーイ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

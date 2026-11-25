using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_13 : CardInfo
{
    public CardInfo_021_JA_13()
    {
        this.cardNo = "021_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マイク・ワゾウスキ";
        this.cardName2 = "お笑いの球道者";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

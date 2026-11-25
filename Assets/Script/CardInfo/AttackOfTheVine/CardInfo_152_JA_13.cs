using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_13 : CardInfo
{
    public CardInfo_152_JA_13()
    {
        this.cardNo = "152_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "サリー";
        this.cardName2 = "怖すぎる怖がらせ屋";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

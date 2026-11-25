using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_13 : CardInfo
{
    public CardInfo_029_JA_13()
    {
        this.cardNo = "029_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "サリー＆ブー";
        this.cardName2 = "怖がらせコンビ";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ComboShift4 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_04 : CardInfo
{
    public CardInfo_115_JA_04()
    {
        this.cardNo = "115_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ムーラン";
        this.cardName2 = "カラミティの仇";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaredMathews;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

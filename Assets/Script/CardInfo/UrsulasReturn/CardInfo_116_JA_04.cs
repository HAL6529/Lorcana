using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_04 : CardInfo
{
    public CardInfo_116_JA_04()
    {
        this.cardNo = "116_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉÄÅ[ÉâÉì";
        this.cardName2 = "ïâèùï∫";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaredMathews;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

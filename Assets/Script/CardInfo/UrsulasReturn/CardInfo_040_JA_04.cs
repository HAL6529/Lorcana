using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_04 : CardInfo
{
    public CardInfo_040_JA_04()
    {
        this.cardNo = "040_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "カミロ・マドリガル";
        this.cardName2 = "イタズラ名人";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

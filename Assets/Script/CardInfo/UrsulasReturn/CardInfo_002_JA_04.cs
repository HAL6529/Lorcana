using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_04 : CardInfo
{
    public CardInfo_002_JA_04()
    {
        this.cardNo = "002_JA_04";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "アルマ・マドリガル";
        this.cardName2 = "母家長";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxineVee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

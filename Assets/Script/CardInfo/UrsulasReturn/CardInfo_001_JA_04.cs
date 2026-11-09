using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_04 : CardInfo
{
    public CardInfo_001_JA_04()
    {
        this.cardNo = "001_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アグスティン・マドリガル";
        this.cardName2 = "ドジなパパ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

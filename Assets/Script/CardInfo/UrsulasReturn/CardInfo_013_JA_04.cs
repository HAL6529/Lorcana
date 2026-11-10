using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_04 : CardInfo
{
    public CardInfo_013_JA_04()
    {
        this.cardNo = "013_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フリエッタ・マドリガル";
        this.cardName2 = "癒しの料理人";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_04 : CardInfo
{
    public CardInfo_045_JA_04()
    {
        this.cardNo = "045_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "イサベラ・マドリガル";
        this.cardName2 = "みんなの憧れ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

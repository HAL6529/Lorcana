using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_04 : CardInfo
{
    public CardInfo_184_JA_04()
    {
        this.cardNo = "184_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ルイーサ・マドリガル";
        this.cardName2 = "家族の要石";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

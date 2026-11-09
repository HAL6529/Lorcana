using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_04 : CardInfo
{
    public CardInfo_019_JA_04()
    {
        this.cardNo = "019_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "予言を探す者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

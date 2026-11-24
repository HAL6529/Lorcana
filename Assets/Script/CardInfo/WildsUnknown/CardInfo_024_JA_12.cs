using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_12 : CardInfo
{
    public CardInfo_024_JA_12()
    {
        this.cardNo = "024_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フリエッタ・マドリガル";
        this.cardName2 = "慈愛のパン職人";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

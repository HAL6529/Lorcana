using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_12 : CardInfo
{
    public CardInfo_006_JA_12()
    {
        this.cardNo = "006_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アグスティン・マドリガル";
        this.cardName2 = "超やさしい夫";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

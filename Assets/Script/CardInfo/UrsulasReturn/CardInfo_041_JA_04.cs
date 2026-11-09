using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_04 : CardInfo
{
    public CardInfo_041_JA_04()
    {
        this.cardNo = "041_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ドロレス・マドリガル";
        this.cardName2 = "地獄耳";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

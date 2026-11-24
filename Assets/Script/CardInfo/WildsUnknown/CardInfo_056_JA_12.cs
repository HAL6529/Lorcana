using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_12 : CardInfo
{
    public CardInfo_056_JA_12()
    {
        this.cardNo = "056_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ペパ・マドリガル";
        this.cardName2 = "嵐の前でも静かよ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarcinKarolewski;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

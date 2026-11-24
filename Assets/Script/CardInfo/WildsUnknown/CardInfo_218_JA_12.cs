using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_12 : CardInfo
{
    public CardInfo_218_JA_12()
    {
        this.cardNo = "218_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ブルーノ・マドリガル";
        this.cardName2 = "オアシスの占い師";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

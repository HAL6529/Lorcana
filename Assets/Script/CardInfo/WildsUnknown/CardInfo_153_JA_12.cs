using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_12 : CardInfo
{
    public CardInfo_153_JA_12()
    {
        this.cardNo = "153_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "イサベラ・マドリガル";
        this.cardName2 = "完璧な制御者";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

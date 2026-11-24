using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_12 : CardInfo
{
    public CardInfo_019_JA_12()
    {
        this.cardNo = "019_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "イサベラ・マドリガル";
        this.cardName2 = "世話好きの栽培者";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

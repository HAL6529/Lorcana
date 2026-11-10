using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_04 : CardInfo
{
    public CardInfo_140_JA_04()
    {
        this.cardNo = "140_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉIÅ[ÉçÉâ";
        this.cardName2 = "ÉçÉAÇÃéÁåÏé“";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

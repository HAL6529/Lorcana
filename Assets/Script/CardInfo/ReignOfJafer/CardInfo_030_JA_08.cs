using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_08 : CardInfo
{
    public CardInfo_030_JA_08()
    {
        this.cardNo = "030_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ライノ";
        this.cardName2 = "パワーハムスター";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

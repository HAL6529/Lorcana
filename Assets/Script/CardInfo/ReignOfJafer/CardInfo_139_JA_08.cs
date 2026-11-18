using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_08 : CardInfo
{
    public CardInfo_139_JA_08()
    {
        this.cardNo = "139_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ルミエール";
        this.cardName2 = "二色に燃えーる";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JustinRunfola;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

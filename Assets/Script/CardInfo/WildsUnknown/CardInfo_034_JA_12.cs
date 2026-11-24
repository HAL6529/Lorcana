using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_12 : CardInfo
{
    public CardInfo_034_JA_12()
    {
        this.cardNo = "034_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アンディの部屋";
        this.cardName2 = "帰るべきところ";
        this.power = 2;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

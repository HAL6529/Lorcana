using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_09 : CardInfo
{
    public CardInfo_130_JA_09()
    {
        this.cardNo = "130_JA_09";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "I 2 I";
        this.cardName2 = "アイ・トゥ・アイ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether9 };
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

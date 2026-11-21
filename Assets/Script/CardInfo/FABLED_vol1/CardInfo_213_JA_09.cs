using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_09 : CardInfo
{
    public CardInfo_213_JA_09()
    {
        this.cardNo = "213_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "STAND OUT";
        this.cardName2 = "スタンド・アウト";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Epic;
    }
}

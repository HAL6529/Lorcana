using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_12 : CardInfo
{
    public CardInfo_032_JA_12()
    {
        this.cardNo = "032_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デ・ン・ワ イッパツ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

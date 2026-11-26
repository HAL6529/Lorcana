using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_14 : CardInfo
{
    public CardInfo_064_JA_14()
    {
        this.cardNo = "064_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "この世で一番素敵な！？";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

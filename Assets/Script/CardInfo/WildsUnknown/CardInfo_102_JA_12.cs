using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_12 : CardInfo
{
    public CardInfo_102_JA_12()
    {
        this.cardNo = "102_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ピザ・プラネット";
        this.cardName2 = "スペースポート";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

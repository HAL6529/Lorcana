using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_099_JA_12 : CardInfo
{
    public CardInfo_099_JA_12()
    {
        this.cardNo = "099_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "カ～ミ～サ～マ～";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

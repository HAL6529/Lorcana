using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_12 : CardInfo
{
    public CardInfo_064_JA_12()
    {
        this.cardNo = "064_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "おれたちがついてるよ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_131_JA_12 : CardInfo
{
    public CardInfo_131_JA_12()
    {
        this.cardNo = "131_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "自由に 大空飛べると 信じて";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

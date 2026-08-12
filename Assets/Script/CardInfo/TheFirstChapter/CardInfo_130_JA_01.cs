using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_01 : CardInfo
{
    public CardInfo_130_JA_01()
    {
        this.cardNo = "130_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ƒhƒ‰ƒSƒ“‚Ì‰Š";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Luis Huerta";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

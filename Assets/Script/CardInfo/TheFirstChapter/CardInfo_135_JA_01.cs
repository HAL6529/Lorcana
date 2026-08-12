using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_01 : CardInfo
{
    public CardInfo_135_JA_01()
    {
        this.cardNo = "135_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "î¸ìøÇÃèÇ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Eri Welli";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

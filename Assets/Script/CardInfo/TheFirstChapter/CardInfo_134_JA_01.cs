using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_134_JA_01 : CardInfo
{
    public CardInfo_134_JA_01()
    {
        this.cardNo = "134_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "“ÅƒŠƒ“ƒS";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Andrew Trabbold";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

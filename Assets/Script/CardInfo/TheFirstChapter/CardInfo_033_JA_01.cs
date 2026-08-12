using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_01 : CardInfo
{
    public CardInfo_033_JA_01()
    {
        this.cardNo = "033_JA_01";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ƒ‰ƒ“ƒ^ƒ“";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Eri Welli";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

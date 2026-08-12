using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_200_JA_01 : CardInfo
{
    public CardInfo_200_JA_01()
    {
        this.cardNo = "200_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "スマッシュ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Simangaliso Sibaya";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

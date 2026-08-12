using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_01 : CardInfo
{
    public CardInfo_162_JA_01()
    {
        this.cardNo = "162_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉoÉçÉbÉNéûë„ÇÃÇ‡ÇÃÇ≈ÇµÇƒ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Kenneth Anderson";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

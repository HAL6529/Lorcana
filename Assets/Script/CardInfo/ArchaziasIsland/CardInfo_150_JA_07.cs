using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_07 : CardInfo
{
    public CardInfo_150_JA_07()
    {
        this.cardNo = "150_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "å^îjÇËÇ»çHãÔ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LeviRogers;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

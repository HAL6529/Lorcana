using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_07 : CardInfo
{
    public CardInfo_177_JA_07()
    {
        this.cardNo = "177_JA_07";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "êÖÇÕãLâØÇéùÇ¬";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Samoldstoree;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

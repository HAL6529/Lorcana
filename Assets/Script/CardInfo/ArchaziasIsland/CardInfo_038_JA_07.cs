using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_07 : CardInfo
{
    public CardInfo_038_JA_07()
    {
        this.cardNo = "038_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ñlÇ™Ç¢ÇÈèÍèä";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

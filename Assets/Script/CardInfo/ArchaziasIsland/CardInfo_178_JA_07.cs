using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_07 : CardInfo
{
    public CardInfo_178_JA_07()
    {
        this.cardNo = "178_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "All Is Found";
        this.cardName2 = "ñÇñ@ÇÃêÏÇÃéqéÁâS";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KuyaJaypi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

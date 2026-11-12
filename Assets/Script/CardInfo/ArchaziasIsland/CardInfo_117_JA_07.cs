using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_07 : CardInfo
{
    public CardInfo_117_JA_07()
    {
        this.cardNo = "117_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "He's a Tramp";
        this.cardName2 = "”Þ‚ªƒgƒ‰ƒ“ƒv‚³";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

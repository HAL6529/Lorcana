using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_07 : CardInfo
{
    public CardInfo_040_JA_07()
    {
        this.cardNo = "040_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "The Family Madrigal";
        this.cardName2 = "‚Ó‚µ‚¬‚Èƒ}ƒhƒŠƒKƒ‹‰Æ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

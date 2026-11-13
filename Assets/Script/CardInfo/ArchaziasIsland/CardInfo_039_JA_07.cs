using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_07 : CardInfo
{
    public CardInfo_039_JA_07()
    {
        this.cardNo = "039_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ä“Ç≥ÇÍÇÈêS";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NicolaSavioriAndLivioCacciatore;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

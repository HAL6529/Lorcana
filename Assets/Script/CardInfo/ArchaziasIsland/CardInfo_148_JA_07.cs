using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_07 : CardInfo
{
    public CardInfo_148_JA_07()
    {
        this.cardNo = "148_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "�̏ᒆ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

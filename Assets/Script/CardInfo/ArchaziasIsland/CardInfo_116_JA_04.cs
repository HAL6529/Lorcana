using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_07 : CardInfo
{
    public CardInfo_116_JA_07()
    {
        this.cardNo = "116_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "アリス！起きて！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

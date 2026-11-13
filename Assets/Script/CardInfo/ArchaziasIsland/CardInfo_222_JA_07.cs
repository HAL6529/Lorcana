using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_07 : CardInfo
{
    public CardInfo_222_JA_07()
    {
        this.cardNo = "222_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "よみがえるアトランティス";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Enchanted;
    }
}

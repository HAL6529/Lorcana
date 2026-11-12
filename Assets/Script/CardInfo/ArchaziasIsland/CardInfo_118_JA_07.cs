using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_07 : CardInfo
{
    public CardInfo_118_JA_07()
    {
        this.cardNo = "118_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒwƒ‰ƒNƒŒƒX‚Ì‹AŠÒ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Legendary;
    }
}

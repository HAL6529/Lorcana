using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_07 : CardInfo
{
    public CardInfo_083_JA_07()
    {
        this.cardNo = "083_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "‚æ‚Ý‚ª‚¦‚é‰¤Š¥";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

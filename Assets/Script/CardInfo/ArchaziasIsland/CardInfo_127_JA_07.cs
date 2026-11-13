using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_127_JA_07 : CardInfo
{
    public CardInfo_127_JA_07()
    {
        this.cardNo = "127_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "サイ・バグ";
        this.cardName2 = "侵略的敵性体";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

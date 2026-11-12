using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_07 : CardInfo
{
    public CardInfo_001_JA_07()
    {
        this.cardNo = "001_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ライノ";
        this.cardName2 = "はげますハムスター";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

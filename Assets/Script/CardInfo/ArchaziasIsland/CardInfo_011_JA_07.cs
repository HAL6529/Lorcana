using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_07 : CardInfo
{
    public CardInfo_011_JA_07()
    {
        this.cardNo = "011_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トルバドール";
        this.cardName2 = "ミュージカル・ナレーター";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1, EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_031_JA_07 : CardInfo
{
    public CardInfo_031_JA_07()
    {
        this.cardNo = "031_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "語り部";
        this.power = 1;
        this.toughness = 2;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.SCG;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

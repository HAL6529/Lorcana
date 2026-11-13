using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_07 : CardInfo
{
    public CardInfo_184_JA_07()
    {
        this.cardNo = "184_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "É{ÉãÉg";
        this.cardName2 = "ï∑Ç≠é®éùÇΩÇ å¢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

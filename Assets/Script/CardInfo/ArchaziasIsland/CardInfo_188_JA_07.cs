using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_07 : CardInfo
{
    public CardInfo_188_JA_07()
    {
        this.cardNo = "188_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ファ・ズー";
        this.cardName2 = "戦の英雄";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MelMilton;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

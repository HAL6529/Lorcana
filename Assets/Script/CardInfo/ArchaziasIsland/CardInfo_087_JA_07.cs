using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_07 : CardInfo
{
    public CardInfo_087_JA_07()
    {
        this.cardNo = "087_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "バッテリー残量低下";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MckayAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

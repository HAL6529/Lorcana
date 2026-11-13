using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_07 : CardInfo
{
    public CardInfo_175_JA_07()
    {
        this.cardNo = "175_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "強化ロボット";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DustinPanzino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

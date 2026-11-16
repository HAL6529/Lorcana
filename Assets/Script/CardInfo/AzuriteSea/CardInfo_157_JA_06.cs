using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_06 : CardInfo
{
    public CardInfo_157_JA_06()
    {
        this.cardNo = "157_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "みんなの平和を守ります";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BriannaGarcia;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

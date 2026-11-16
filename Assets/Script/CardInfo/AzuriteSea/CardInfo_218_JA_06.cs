using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_06 : CardInfo
{
    public CardInfo_218_JA_06()
    {
        this.cardNo = "218_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ベイマックス";
        this.cardName2 = "あなたの健康を守ります";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaredMathews;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}

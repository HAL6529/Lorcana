using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_12 : CardInfo
{
    public CardInfo_126_JA_12()
    {
        this.cardNo = "126_JA_12";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "シド・フィリップス";
        this.cardName2 = "おもちゃの外科医";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

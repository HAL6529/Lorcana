using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_05 : CardInfo
{
    public CardInfo_120_JA_05()
    {
        this.cardNo = "120_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "お菓子独り占めマン";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

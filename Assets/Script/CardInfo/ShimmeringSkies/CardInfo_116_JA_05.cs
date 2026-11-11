using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_05 : CardInfo
{
    public CardInfo_116_JA_05()
    {
        this.cardNo = "116_JA_05";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ピート";
        this.cardName2 = "蒸気船のライバル";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LouisJones;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

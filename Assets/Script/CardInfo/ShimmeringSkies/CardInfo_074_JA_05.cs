using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_05 : CardInfo
{
    public CardInfo_074_JA_05()
    {
        this.cardNo = "074_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "エド";
        this.cardName2 = "笑うハイエナ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

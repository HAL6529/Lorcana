using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_05 : CardInfo
{
    public CardInfo_087_JA_05()
    {
        this.cardNo = "087_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "バンザイ";
        this.cardName2 = "あざけるハイエナ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

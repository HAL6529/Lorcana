using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_05 : CardInfo
{
    public CardInfo_125_JA_05()
    {
        this.cardNo = "125_JA_05";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ÉVÉìÉo";
        this.cardName2 = "ñ`åØçDÇ´Ç»åpè≥é“";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinPalombo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

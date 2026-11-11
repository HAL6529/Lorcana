using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_05 : CardInfo
{
    public CardInfo_110_JA_05()
    {
        this.cardNo = "110_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "スノワナ・レインボー";
        this.cardName2 = "クール・コンペティター";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimangalisoSibaya;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

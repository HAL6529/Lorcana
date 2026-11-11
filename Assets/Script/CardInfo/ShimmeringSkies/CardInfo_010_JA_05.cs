using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_05 : CardInfo
{
    public CardInfo_010_JA_05()
    {
        this.cardNo = "010_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フィックス・イット・フェリックス JR.";
        this.cardName2 = "頼りになる修理工";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigHaggman_Sund;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

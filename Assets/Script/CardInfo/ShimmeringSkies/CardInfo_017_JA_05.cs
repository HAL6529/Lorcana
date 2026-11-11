using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_05 : CardInfo
{
    public CardInfo_017_JA_05()
    {
        this.cardNo = "017_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "フィックス・イット・フェリックス JR.";
        this.cardName2 = "浮かれた観光客";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

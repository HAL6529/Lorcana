using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_05 : CardInfo
{
    public CardInfo_012_JA_05()
    {
        this.cardNo = "012_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フィックス・イット・フェリックス JR.";
        this.cardName2 = "ナイスランドの管理人";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

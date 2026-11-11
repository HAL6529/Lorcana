using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_05 : CardInfo
{
    public CardInfo_011_JA_05()
    {
        this.cardNo = "011_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ガゼル";
        this.cardName2 = "ポップスター";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

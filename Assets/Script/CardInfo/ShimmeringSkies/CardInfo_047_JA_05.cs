using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_05 : CardInfo
{
    public CardInfo_047_JA_05()
    {
        this.cardNo = "047_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "電撃フクロウ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Evasive, EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

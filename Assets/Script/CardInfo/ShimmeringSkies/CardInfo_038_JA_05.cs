using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_05 : CardInfo
{
    public CardInfo_038_JA_05()
    {
        this.cardNo = "038_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "É}Å[ÉäÉì";
        this.cardName2 = "ÉJÉÅ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

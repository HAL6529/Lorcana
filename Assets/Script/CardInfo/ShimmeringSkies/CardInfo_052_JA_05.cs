using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_05 : CardInfo
{
    public CardInfo_052_JA_05()
    {
        this.cardNo = "052_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "モンストロ";
        this.cardName2 = "クジラの王様";
        this.power = 5;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IvanShavrin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

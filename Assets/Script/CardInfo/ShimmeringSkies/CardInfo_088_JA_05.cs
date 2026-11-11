using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_05 : CardInfo
{
    public CardInfo_088_JA_05()
    {
        this.cardNo = "088_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "賢明なる探偵";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

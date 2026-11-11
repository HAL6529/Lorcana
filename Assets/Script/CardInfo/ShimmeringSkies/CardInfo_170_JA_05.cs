using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_05 : CardInfo
{
    public CardInfo_170_JA_05()
    {
        this.cardNo = "170_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マーリンの小屋";
        this.cardName2 = "魔法使いの家";
        this.power = 1;
        this.toughness = 7;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.Gabe;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

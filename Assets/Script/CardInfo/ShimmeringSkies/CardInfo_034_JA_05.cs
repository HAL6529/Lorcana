using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_05 : CardInfo
{
    public CardInfo_034_JA_05()
    {
        this.cardNo = "034_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プライドランド";
        this.cardName2 = "ジャングルのオアシス";
        this.power = 2;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewOates;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

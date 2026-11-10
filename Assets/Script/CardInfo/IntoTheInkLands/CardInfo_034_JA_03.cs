using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_03 : CardInfo
{
    public CardInfo_034_JA_03()
    {
        this.cardNo = "034_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ティアナズ・パレス";
        this.cardName2 = "ジャズレストラン";
        this.power = 2;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

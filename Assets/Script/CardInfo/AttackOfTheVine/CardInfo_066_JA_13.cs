using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_066_JA_13 : CardInfo
{
    public CardInfo_066_JA_13()
    {
        this.cardNo = "066_JA_13";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "硬直";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GeoffreyBoudout;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_06 : CardInfo
{
    public CardInfo_170_JA_06()
    {
        this.cardNo = "170_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "サンフランソウキョウ工科大学";
        this.cardName2 = "名門の学び舎";
        this.power = 1;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.Gabe;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

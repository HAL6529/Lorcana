using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_06 : CardInfo
{
    public CardInfo_100_JA_06()
    {
        this.cardNo = "100_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "“]‘—ƒ|ƒbƒh";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

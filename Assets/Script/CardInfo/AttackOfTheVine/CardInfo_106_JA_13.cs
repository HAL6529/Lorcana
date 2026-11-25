using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_13 : CardInfo
{
    public CardInfo_106_JA_13()
    {
        this.cardNo = "106_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "わたしの冒険ブック";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.McKayAnderson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

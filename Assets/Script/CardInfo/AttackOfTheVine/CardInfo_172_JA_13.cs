using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_13 : CardInfo
{
    public CardInfo_172_JA_13()
    {
        this.cardNo = "172_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "笑いボンベ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RudyHill;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

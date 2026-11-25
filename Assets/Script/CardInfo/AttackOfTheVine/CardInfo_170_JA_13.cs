using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_13 : CardInfo
{
    public CardInfo_170_JA_13()
    {
        this.cardNo = "170_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "クローゼットへのポータル";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JaimePuga;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.SuperRare;
    }
}

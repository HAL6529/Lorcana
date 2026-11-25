using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_13 : CardInfo
{
    public CardInfo_036_JA_13()
    {
        this.cardNo = "036_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "パウアタンの杖";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Gwawi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

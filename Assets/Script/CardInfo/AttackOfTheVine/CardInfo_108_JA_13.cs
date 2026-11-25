using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_13 : CardInfo
{
    public CardInfo_108_JA_13()
    {
        this.cardNo = "108_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パラダイスの滝";
        this.cardName2 = "エキゾチックな目的地";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaimePuga;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

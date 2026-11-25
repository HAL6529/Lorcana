using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_13 : CardInfo
{
    public CardInfo_205_JA_13()
    {
        this.cardNo = "205_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エクサカリバー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_206_JA_13 : CardInfo
{
    public CardInfo_206_JA_13()
    {
        this.cardNo = "206_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "スイコミカズラ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndrewPenaAndSergioMancinelli;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

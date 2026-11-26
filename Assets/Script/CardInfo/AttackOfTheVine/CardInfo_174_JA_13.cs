using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_13 : CardInfo
{
    public CardInfo_174_JA_13()
    {
        this.cardNo = "174_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "大いなるはちみつの書";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KaitlinCuthbertson;
        this.classList = new List<EnumController.Class> { EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

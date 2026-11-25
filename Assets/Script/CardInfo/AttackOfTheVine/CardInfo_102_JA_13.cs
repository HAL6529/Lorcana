using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_13 : CardInfo
{
    public CardInfo_102_JA_13()
    {
        this.cardNo = "102_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "つるの貫き";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndrewTheophilopoulos;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

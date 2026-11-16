using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_201_JA_06 : CardInfo
{
    public CardInfo_201_JA_06()
    {
        this.cardNo = "201_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トレーニング人形";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

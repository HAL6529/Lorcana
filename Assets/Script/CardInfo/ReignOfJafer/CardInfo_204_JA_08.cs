using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_08 : CardInfo
{
    public CardInfo_204_JA_08()
    {
        this.cardNo = "204_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ハムスターボール";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

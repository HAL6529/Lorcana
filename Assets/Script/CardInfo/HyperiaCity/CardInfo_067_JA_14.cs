using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_14 : CardInfo
{
    public CardInfo_067_JA_14()
    {
        this.cardNo = "067_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "インクキャスターのスケート";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GiuseppeDiMaio;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

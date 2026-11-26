using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_14 : CardInfo
{
    public CardInfo_164_JA_14()
    {
        this.cardNo = "164_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "入念な調査";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

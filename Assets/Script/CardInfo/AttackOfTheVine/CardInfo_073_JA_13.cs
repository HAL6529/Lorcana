using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_13 : CardInfo
{
    public CardInfo_073_JA_13()
    {
        this.cardNo = "073_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ストーンサークル";
        this.cardName2 = "ヴァインズの支配下";
        this.power = 1;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

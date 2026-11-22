using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_10 : CardInfo
{
    public CardInfo_202_JA_10()
    {
        this.cardNo = "202_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "イルミナのトンネル";
        this.cardName2 = "繋がり合った洞窟網";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DaveMitchesonAndPaulHogg;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.SuperRare;
    }
}

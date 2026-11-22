using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_10 : CardInfo
{
    public CardInfo_163_JA_10()
    {
        this.cardNo = "163_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "つまづいた！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

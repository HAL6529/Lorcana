using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_03 : CardInfo
{
    public CardInfo_161_JA_03()
    {
        this.cardNo = "161_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "How Far I'll Go";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AnnaRudAndAnnnaStosik;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

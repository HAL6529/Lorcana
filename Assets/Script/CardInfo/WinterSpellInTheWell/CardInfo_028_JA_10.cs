using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_10 : CardInfo
{
    public CardInfo_028_JA_10()
    {
        this.cardNo = "028_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "デラの月の子守歌";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.BeatriceBlueAndOttoParedes;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

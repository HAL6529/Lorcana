using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_094_JA_03 : CardInfo
{
    public CardInfo_094_JA_03()
    {
        this.cardNo = "094_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "óˆÇµÇøÇ·ÇüÇüÇüÇ¡ÇΩÇÌÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.HyunaLee;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

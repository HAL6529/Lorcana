using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_03 : CardInfo
{
    public CardInfo_061_JA_03()
    {
        this.cardNo = "061_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "Ž„‚ðŒÄ‚ñ‚Å‚é";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

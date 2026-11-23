using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_11 : CardInfo
{
    public CardInfo_064_JA_11()
    {
        this.cardNo = "064_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "COLORS OF THE WIND";
        this.cardName2 = "カラー・オブ・ザ・ウィンド";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.SuperRare;
    }
}

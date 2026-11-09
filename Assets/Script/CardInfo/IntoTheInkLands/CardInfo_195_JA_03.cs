using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_03 : CardInfo
{
    public CardInfo_195_JA_03()
    {
        this.cardNo = "195_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÇªÇ±Ç…ìoèÍÅAÉ[ÉEÉXÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IsabellaCeravolo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

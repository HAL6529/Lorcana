using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_01 : CardInfo
{
    public CardInfo_095_JA_01()
    {
        this.cardNo = "095_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "MOTHER KNOWS BEST";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "R. La Barbera / L. Giammichele";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

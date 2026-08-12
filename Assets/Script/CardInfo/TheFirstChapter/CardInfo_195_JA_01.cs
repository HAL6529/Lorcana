using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_01 : CardInfo
{
    public CardInfo_195_JA_01()
    {
        this.cardNo = "195_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "A WHOLE NEW WORLD";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Koni";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_01 : CardInfo
{
    public CardInfo_025_JA_01()
    {
        this.cardNo = "025_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "BE OUR GUEST";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "R.La Barbera / L. Giammichele";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

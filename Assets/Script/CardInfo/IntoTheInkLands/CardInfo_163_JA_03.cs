using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_03 : CardInfo
{
    public CardInfo_163_JA_03()
    {
        this.cardNo = "163_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "オーレリアン・ジャイロセンサー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

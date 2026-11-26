using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_14 : CardInfo
{
    public CardInfo_060_JA_14()
    {
        this.cardNo = "060_JA_14";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "Everyone Knows Juanita";
        this.cardName2 = "あこがれのファニータ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

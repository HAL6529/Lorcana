using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_131_JA_14 : CardInfo
{
    public CardInfo_131_JA_14()
    {
        this.cardNo = "131_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "お別れだけど";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.ArtieRodriguez;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

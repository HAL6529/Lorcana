using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_063_JA_14 : CardInfo
{
    public CardInfo_063_JA_14()
    {
        this.cardNo = "063_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "UN POCO LOCO";
        this.cardName2 = "ウン・ポコ・ロコ";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.BoliNolascoAndCesarVergara;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether3 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_14 : CardInfo
{
    public CardInfo_029_JA_14()
    {
        this.cardNo = "029_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "Remember Me";
        this.cardName2 = "リメンバー・ミー";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether6 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_08 : CardInfo
{
    public CardInfo_202_JA_08()
    {
        this.cardNo = "202_JA_08";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ビヨンド・ザ・ホライズン";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Taraneh;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether7 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_200_JA_14 : CardInfo
{
    public CardInfo_200_JA_14()
    {
        this.cardNo = "200_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "人気のお店にするわ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GianlucaBarone;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

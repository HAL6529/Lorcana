using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_14 : CardInfo
{
    public CardInfo_163_JA_14()
    {
        this.cardNo = "163_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "しびれて参ってるよ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GeoffreyBoudout;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

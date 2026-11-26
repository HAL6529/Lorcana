using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_14 : CardInfo
{
    public CardInfo_028_JA_14()
    {
        this.cardNo = "028_JA_14";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "NEVER TOO FAR APART";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.PalomaSauvage;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether9 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_14 : CardInfo
{
    public CardInfo_030_JA_14()
    {
        this.cardNo = "030_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "NEVER GONNA LET YOU CRY";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MaxineVee;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

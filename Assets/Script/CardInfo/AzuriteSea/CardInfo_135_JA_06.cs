using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_06 : CardInfo
{
    public CardInfo_135_JA_06()
    {
        this.cardNo = "135_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "カカモラ船団";
        this.cardName2 = "ココナッツ艦隊";
        this.power = 2;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

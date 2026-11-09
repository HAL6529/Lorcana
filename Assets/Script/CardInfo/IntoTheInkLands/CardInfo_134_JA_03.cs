using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_134_JA_03 : CardInfo
{
    public CardInfo_134_JA_03()
    {
        this.cardNo = "134_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アグラバー";
        this.cardName2 = "市場";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KaitlinCuthbertson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

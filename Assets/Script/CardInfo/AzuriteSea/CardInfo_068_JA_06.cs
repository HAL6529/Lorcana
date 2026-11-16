using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_06 : CardInfo
{
    public CardInfo_068_JA_06()
    {
        this.cardNo = "068_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フェアリーシップ";
        this.cardName2 = "高貴なる船";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KristenKaluba;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

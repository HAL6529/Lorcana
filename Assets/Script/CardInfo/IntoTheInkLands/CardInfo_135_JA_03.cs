using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_03 : CardInfo
{
    public CardInfo_135_JA_03()
    {
        this.cardNo = "135_JA_03";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ジョリーロジャー号";
        this.cardName2 = "フック船長の船";
        this.power = 2;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

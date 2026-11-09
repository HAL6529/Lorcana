using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_03 : CardInfo
{
    public CardInfo_032_JA_03()
    {
        this.cardNo = "032_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ネバーランド";
        this.cardName2 = "人魚の入り江";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CaclieCarre;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

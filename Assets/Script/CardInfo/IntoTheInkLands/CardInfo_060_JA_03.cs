using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_03 : CardInfo
{
    public CardInfo_060_JA_03()
    {
        this.cardNo = "060_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "‘¡‚è•¨‚ðŽö‚¯‚æ‚¤";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DylanBonner;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

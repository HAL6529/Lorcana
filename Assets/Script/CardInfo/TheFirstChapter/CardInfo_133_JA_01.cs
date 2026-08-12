using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_01 : CardInfo
{
    public CardInfo_133_JA_01()
    {
        this.cardNo = "133_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‚©‚ç‚Ý‚Â‚«!";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Eri Welli";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

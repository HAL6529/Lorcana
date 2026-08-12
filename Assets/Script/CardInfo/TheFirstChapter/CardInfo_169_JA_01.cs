using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_01 : CardInfo
{
    public CardInfo_169_JA_01()
    {
        this.cardNo = "169_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "–‚–@‚Ì‰©‹à‰Ô";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Cory Godbey";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

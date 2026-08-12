using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_01 : CardInfo
{
    public CardInfo_170_JA_01()
    {
        this.cardNo = "170_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉAÉåÉìÉfÅ[ÉãÇÃâ§‚î";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Grace Tran";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

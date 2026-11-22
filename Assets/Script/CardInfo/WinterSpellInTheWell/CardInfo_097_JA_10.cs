using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_10 : CardInfo
{
    public CardInfo_097_JA_10()
    {
        this.cardNo = "097_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "俺は悪党！意地悪！下品！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarceloVignali;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

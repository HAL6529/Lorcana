using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_01 : CardInfo
{
    public CardInfo_097_JA_01()
    {
        this.cardNo = "097_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "”hŽè‚ÉŽØ‚è‚é‚º";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Hadvig Haggman-Sund";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

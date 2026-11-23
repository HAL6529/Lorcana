using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_11 : CardInfo
{
    public CardInfo_097_JA_11()
    {
        this.cardNo = "097_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "あの世行き！知恵がないとね";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

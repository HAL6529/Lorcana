using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_05 : CardInfo
{
    public CardInfo_213_JA_05()
    {
        this.cardNo = "213_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "You're Welcome";
        this.cardName2 = "‰´‚Ì‚¨‚©‚°‚³";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Enchanted;
    }
}

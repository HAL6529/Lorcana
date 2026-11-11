using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_05 : CardInfo
{
    public CardInfo_061_JA_05()
    {
        this.cardNo = "061_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "We Know the Way";
        this.cardName2 = "‚à‚Á‚Æ‰“‚­‚Ö";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JakeMurphy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

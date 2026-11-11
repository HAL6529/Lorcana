using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_05 : CardInfo
{
    public CardInfo_102_JA_05()
    {
        this.cardNo = "102_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "îMë—âJó—";
        this.cardName2 = "ÉWÉÉÉKÅ[ÇÃÇÀÇÆÇÁ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreasRocha;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}

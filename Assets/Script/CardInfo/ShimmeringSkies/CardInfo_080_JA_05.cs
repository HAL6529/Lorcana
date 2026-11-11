using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_05 : CardInfo
{
    public CardInfo_080_JA_05()
    {
        this.cardNo = "080_JA_05";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ƒoƒ“ƒUƒC";
        this.cardName2 = "‘å“÷‹ò‚ç‚¢";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

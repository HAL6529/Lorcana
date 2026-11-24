using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_12 : CardInfo
{
    public CardInfo_072_JA_12()
    {
        this.cardNo = "072_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "トッド";
        this.cardName2 = "機敏なきつね";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

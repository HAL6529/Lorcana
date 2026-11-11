using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_05 : CardInfo
{
    public CardInfo_072_JA_05()
    {
        this.cardNo = "072_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ザズー";
        this.cardName2 = "ムファサの相談役";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KuyaJaypi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

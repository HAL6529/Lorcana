using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_05 : CardInfo
{
    public CardInfo_073_JA_05()
    {
        this.cardNo = "073_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ウルフ";
        this.cardName2 = "パントマイマー";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

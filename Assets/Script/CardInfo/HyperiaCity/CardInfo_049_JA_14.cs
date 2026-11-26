using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_14 : CardInfo
{
    public CardInfo_049_JA_14()
    {
        this.cardNo = "049_JA_14";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "フォックス・ザナトス";
        this.cardName2 = "カリスマ的無法者";
        this.power = 5;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CelesteJamneck;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

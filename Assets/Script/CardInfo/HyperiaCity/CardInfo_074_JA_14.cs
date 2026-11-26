using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_14 : CardInfo
{
    public CardInfo_074_JA_14()
    {
        this.cardNo = "074_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キット・クラウドキッカー";
        this.cardName2 = "わんぱくなクマ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

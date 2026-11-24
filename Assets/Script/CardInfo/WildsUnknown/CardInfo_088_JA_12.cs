using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_12 : CardInfo
{
    public CardInfo_088_JA_12()
    {
        this.cardNo = "088_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジョシュア・スウィート";
        this.cardName2 = "野戦外科医";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

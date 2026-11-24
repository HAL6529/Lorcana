using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_12 : CardInfo
{
    public CardInfo_073_JA_12()
    {
        this.cardNo = "073_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヘルガ・シンクレア";
        this.cardName2 = "援護不要";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MagentaMuracaAndGraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

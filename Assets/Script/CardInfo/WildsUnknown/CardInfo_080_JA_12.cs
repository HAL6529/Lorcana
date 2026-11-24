using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_12 : CardInfo
{
    public CardInfo_080_JA_12()
    {
        this.cardNo = "080_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ガエタン・モリエール";
        this.cardName2 = "穴掘り名人";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LorenaPiloreta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

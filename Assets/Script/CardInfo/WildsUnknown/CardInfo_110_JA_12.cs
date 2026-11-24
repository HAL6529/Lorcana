using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_12 : CardInfo
{
    public CardInfo_110_JA_12()
    {
        this.cardNo = "110_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "プレストン・ウィットモア";
        this.cardName2 = "探検隊の出資者";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

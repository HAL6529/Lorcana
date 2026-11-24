using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_12 : CardInfo
{
    public CardInfo_093_JA_12()
    {
        this.cardNo = "093_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ヘルガ・シンクレア";
        this.cardName2 = "万全の備え";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MagentaMuraca;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

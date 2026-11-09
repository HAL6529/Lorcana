using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_03 : CardInfo
{
    public CardInfo_074_JA_03()
    {
        this.cardNo = "074_JA_03";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ヘルガ・シンクレア";
        this.cardName2 = "ファム・ファタール";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

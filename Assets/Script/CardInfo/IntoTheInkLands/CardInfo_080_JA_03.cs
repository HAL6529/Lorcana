using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_03 : CardInfo
{
    public CardInfo_080_JA_03()
    {
        this.cardNo = "080_JA_03";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "マイロ・サッチ";
        this.cardName2 = "アトランティスの王";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

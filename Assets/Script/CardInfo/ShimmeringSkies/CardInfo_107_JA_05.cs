using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_05 : CardInfo
{
    public CardInfo_107_JA_05()
    {
        this.cardNo = "107_JA_05";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "パイ投げ名人";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

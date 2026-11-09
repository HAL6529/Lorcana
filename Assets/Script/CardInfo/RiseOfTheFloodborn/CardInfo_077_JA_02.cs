using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_02 : CardInfo
{
    public CardInfo_077_JA_02()
    {
        this.cardNo = "077_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "立派な紳士";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

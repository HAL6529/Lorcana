using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_09 : CardInfo
{
    public CardInfo_077_JA_09()
    {
        this.cardNo = "077_JA_09";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マックス・グーフ";
        this.cardName2 = "チャート・トッパー";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

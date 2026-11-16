using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_06 : CardInfo
{
    public CardInfo_089_JA_06()
    {
        this.cardNo = "089_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "腕利き船大工";
        this.power = 1;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

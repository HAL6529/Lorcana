using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_06 : CardInfo
{
    public CardInfo_084_JA_06()
    {
        this.cardNo = "084_JA_06";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉWÉÉÉXÉ~Éì";
        this.cardName2 = "çÇãMÇ»ÇÈíÒì¬";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

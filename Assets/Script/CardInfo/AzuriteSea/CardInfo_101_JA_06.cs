using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_06 : CardInfo
{
    public CardInfo_101_JA_06()
    {
        this.cardNo = "101_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "îjñ≈ÇÃñ¿ê}";
        this.cardName2 = "êÖÇÃëÂñ¿ã{";
        this.power = 1;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewOates;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

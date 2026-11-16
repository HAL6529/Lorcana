using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_06 : CardInfo
{
    public CardInfo_102_JA_06()
    {
        this.cardNo = "102_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉtÉNÉçÉEìá";
        this.cardName2 = "îÈÇﬂÇÁÇÍÇΩì¸ÇËå˚";
        this.power = 1;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

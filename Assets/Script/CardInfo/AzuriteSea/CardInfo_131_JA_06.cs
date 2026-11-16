using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_131_JA_06 : CardInfo
{
    public CardInfo_131_JA_06()
    {
        this.cardNo = "131_JA_06";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "‰öŒõ”j";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarcoGiorgianni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

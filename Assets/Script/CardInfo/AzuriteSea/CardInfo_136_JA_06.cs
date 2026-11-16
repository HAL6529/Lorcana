using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_06 : CardInfo
{
    public CardInfo_136_JA_06()
    {
        this.cardNo = "136_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉhÉNÉçä‚";
        this.cardName2 = "ê‚äCÇÃóvç«";
        this.power = 1;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}

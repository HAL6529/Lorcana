using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_096_JA_06 : CardInfo
{
    public CardInfo_096_JA_06()
    {
        this.cardNo = "096_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "’ŽŽh‚³‚ê";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

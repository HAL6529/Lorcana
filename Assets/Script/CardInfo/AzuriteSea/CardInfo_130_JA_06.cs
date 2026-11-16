using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_06 : CardInfo
{
    public CardInfo_130_JA_06()
    {
        this.cardNo = "130_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "“‡‚ª‚ ‚é‚Ì‚à‰´‚Ì‚¨‚©‚°";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

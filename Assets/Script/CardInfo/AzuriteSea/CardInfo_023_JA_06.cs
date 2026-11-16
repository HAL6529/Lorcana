using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_06 : CardInfo
{
    public CardInfo_023_JA_06()
    {
        this.cardNo = "023_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉãÅ[";
        this.cardName2 = "Ç¢ÇøÇŒÇÒÇøÇ¢Ç≥Ç»äCëØ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GianlucaBarone;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

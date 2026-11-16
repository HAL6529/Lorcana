using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_06 : CardInfo
{
    public CardInfo_020_JA_06()
    {
        this.cardNo = "020_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ÉVÉìÉo";
        this.cardName2 = "ãCçÇÇ´åQÇÍÇÃéÁåÏé“";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

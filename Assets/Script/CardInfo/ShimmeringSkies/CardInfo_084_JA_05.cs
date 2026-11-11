using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_05 : CardInfo
{
    public CardInfo_084_JA_05()
    {
        this.cardNo = "084_JA_05";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ÉNÉâÉâÉxÉã";
        this.cardName2 = "åyÇ‚Ç©Ç»Ç–Ç√ÇﬂÇÃéùÇøéÂ";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JenniferParkAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

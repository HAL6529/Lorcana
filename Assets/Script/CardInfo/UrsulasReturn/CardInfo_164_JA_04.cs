using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_04 : CardInfo
{
    public CardInfo_164_JA_04()
    {
        this.cardNo = "164_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "–²‚Í‚Ü‚Ú‚ë‚µ‚¾‚ÆŒ¾‚¤‚¯‚ê‚Ç";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

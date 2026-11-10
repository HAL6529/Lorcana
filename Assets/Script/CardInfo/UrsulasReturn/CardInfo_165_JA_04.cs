using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_165_JA_04 : CardInfo
{
    public CardInfo_165_JA_04()
    {
        this.cardNo = "165_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "‚È‚ñ‚Ä‚½‚­‚³‚ñ‚Ì•ó•¨";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MattGaser;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

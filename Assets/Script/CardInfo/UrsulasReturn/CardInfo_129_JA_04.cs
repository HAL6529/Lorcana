using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_04 : CardInfo
{
    public CardInfo_129_JA_04()
    {
        this.cardNo = "129_JA_04";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "‘¸Œh‚³‚ê‚é‰¤‚É";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}

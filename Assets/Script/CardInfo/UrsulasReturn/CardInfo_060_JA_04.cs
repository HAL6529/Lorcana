using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_04 : CardInfo
{
    public CardInfo_060_JA_04()
    {
        this.cardNo = "060_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Poor Unfortunate Souls";
        this.cardName2 = "à£ÇÍÇ»êlÅX";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

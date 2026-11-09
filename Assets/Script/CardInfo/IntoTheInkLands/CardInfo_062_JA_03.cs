using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_03 : CardInfo
{
    public CardInfo_062_JA_03()
    {
        this.cardNo = "062_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ìyídèÍÇÃï±ì¨";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

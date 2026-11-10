using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_03 : CardInfo
{
    public CardInfo_027_JA_03()
    {
        this.cardNo = "027_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "âûã}èCóù";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

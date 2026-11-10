using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_04 : CardInfo
{
    public CardInfo_062_JA_04()
    {
        this.cardNo = "062_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ãŸã}ÉvÉâÉìGOÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

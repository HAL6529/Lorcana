using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_031_JA_12 : CardInfo
{
    public CardInfo_031_JA_12()
    {
        this.cardNo = "031_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "この道こそ私なの";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

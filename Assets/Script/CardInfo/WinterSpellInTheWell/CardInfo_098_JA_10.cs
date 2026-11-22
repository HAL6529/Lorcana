using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_10 : CardInfo
{
    public CardInfo_098_JA_10()
    {
        this.cardNo = "098_JA_10";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "呪いの薬";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.NicolasKy;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.SuperRare;
    }
}

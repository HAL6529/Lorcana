using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_063_JA_10 : CardInfo
{
    public CardInfo_063_JA_10()
    {
        this.cardNo = "063_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "急降下攻撃";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GabrielNascimento;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_11 : CardInfo
{
    public CardInfo_168_JA_11()
    {
        this.cardNo = "168_JA_11";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ダークウィングのくつろぎチェア";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DaniellePowers;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

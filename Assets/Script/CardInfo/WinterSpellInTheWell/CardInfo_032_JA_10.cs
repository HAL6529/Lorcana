using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_10 : CardInfo
{
    public CardInfo_032_JA_10()
    {
        this.cardNo = "032_JA_10";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ブラック・コルドロン";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KaitlinCuthbertson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Legendary;
    }
}

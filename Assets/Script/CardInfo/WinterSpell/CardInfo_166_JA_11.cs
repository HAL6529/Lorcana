using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_166_JA_11 : CardInfo
{
    public CardInfo_166_JA_11()
    {
        this.cardNo = "166_JA_11";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "青い煙玉";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.HanaAugustine;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

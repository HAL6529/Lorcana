using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_11 : CardInfo
{
    public CardInfo_065_JA_11()
    {
        this.cardNo = "065_JA_11";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "母さんの首飾り";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_13 : CardInfo
{
    public CardInfo_140_JA_13()
    {
        this.cardNo = "140_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "無数の風船";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.WietseTreurniet;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_13 : CardInfo
{
    public CardInfo_032_JA_13()
    {
        this.cardNo = "032_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "IF I DIDN'T HAVE YOU";
        this.cardName2 = "君がいないと";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_201_JA_11 : CardInfo
{
    public CardInfo_201_JA_11()
    {
        this.cardNo = "201_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "桃外線ウルトラ探査スコープ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}

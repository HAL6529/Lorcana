using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_13 : CardInfo
{
    public CardInfo_202_JA_13()
    {
        this.cardNo = "202_JA_13";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ヴァインズ・アタック！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

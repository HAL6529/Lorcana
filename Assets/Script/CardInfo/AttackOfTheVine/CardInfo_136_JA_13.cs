using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_13 : CardInfo
{
    public CardInfo_136_JA_13()
    {
        this.cardNo = "136_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ガオー！！！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

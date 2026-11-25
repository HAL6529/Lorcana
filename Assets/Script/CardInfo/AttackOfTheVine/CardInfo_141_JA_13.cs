using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_13 : CardInfo
{
    public CardInfo_141_JA_13()
    {
        this.cardNo = "141_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "野獣の城";
        this.cardName2 = "ヴァインズ占拠";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JimmyLo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}

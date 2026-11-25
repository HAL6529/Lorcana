using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_13 : CardInfo
{
    public CardInfo_204_JA_13()
    {
        this.cardNo = "204_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "捨て去られた鎧";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KatlinCuthbertson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}

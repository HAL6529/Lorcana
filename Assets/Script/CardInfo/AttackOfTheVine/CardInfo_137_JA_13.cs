using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_13 : CardInfo
{
    public CardInfo_137_JA_13()
    {
        this.cardNo = "137_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "予言の幻視";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JulesDubost;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

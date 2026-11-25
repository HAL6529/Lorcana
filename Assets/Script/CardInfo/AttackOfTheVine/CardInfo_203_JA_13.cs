using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_13 : CardInfo
{
    public CardInfo_203_JA_13()
    {
        this.cardNo = "203_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "暴風";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndreasRocha;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}

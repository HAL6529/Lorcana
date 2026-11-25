using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_13 : CardInfo
{
    public CardInfo_068_JA_13()
    {
        this.cardNo = "068_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "護りのオーラ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LaurenLevering;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_13 : CardInfo
{
    public CardInfo_167_JA_13()
    {
        this.cardNo = "167_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "集中して探せ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Common;
    }
}

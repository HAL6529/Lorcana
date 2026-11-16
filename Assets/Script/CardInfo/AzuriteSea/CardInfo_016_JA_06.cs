using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_06 : CardInfo
{
    public CardInfo_016_JA_06()
    {
        this.cardNo = "016_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ティアナ";
        this.cardName2 = "ジャズレストランのオーナー";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarineJosephine;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

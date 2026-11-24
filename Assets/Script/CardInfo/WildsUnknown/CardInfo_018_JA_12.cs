using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_12 : CardInfo
{
    public CardInfo_018_JA_12()
    {
        this.cardNo = "018_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アリエル";
        this.cardName2 = "好奇な旅人";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ClioWolfensberger;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

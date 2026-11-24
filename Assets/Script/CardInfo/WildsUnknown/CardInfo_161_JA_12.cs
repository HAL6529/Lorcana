using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_12 : CardInfo
{
    public CardInfo_161_JA_12()
    {
        this.cardNo = "161_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アースラ";
        this.cardName2 = "取り引きの仕掛屋";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaredMathews;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

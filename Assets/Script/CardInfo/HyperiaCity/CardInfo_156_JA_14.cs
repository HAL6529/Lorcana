using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_14 : CardInfo
{
    public CardInfo_156_JA_14()
    {
        this.cardNo = "156_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アリエル";
        this.cardName2 = "非日常の収集家";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuoloAndAdamFord;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

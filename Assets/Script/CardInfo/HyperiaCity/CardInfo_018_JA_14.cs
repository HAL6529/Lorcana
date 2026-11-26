using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_14 : CardInfo
{
    public CardInfo_018_JA_14()
    {
        this.cardNo = "018_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ライオンハート";
        this.cardName2 = "現職市長";
        this.power = 4;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

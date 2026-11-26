using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_14 : CardInfo
{
    public CardInfo_079_JA_14()
    {
        this.cardNo = "079_JA_14";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "レディ";
        this.cardName2 = "ゆったりゆっくり";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

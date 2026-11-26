using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_14 : CardInfo
{
    public CardInfo_013_JA_14()
    {
        this.cardNo = "013_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マンチャス";
        this.cardName2 = "笑顔の運転手";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DevMadanAndEriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

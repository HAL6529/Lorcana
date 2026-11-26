using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_14 : CardInfo
{
    public CardInfo_088_JA_14()
    {
        this.cardNo = "088_JA_14";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ドン・カルナージ";
        this.cardName2 = "華麗なる海賊";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Prince, EnumController.Class.Pirate};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

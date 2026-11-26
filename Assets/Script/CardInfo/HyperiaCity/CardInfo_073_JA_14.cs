using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_14 : CardInfo
{
    public CardInfo_073_JA_14()
    {
        this.cardNo = "073_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "モーリー・カニングハム";
        this.cardName2 = "みんなと分け合う子";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AnneNeyens;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

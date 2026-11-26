using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_14 : CardInfo
{
    public CardInfo_008_JA_14()
    {
        this.cardNo = "008_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ヤックス";
        this.cardName2 = "コンサート好き";
        this.power = 7;
        this.toughness = 9;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_14 : CardInfo
{
    public CardInfo_178_JA_14()
    {
        this.cardNo = "178_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ウールター＆ジェシー";
        this.cardName2 = "ベルウェザーの手下";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

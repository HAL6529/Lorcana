using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_14 : CardInfo
{
    public CardInfo_020_JA_14()
    {
        this.cardNo = "020_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラッセル";
        this.cardName2 = "冒険を探す少年";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_08 : CardInfo
{
    public CardInfo_100_JA_08()
    {
        this.cardNo = "100_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ラーヤ";
        this.cardName2 = "潜入の達人";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DustinPanzino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

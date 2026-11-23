using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_11 : CardInfo
{
    public CardInfo_153_JA_11()
    {
        this.cardNo = "153_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スプラッター・フェニックス";
        this.cardName2 = "認められないアーティスト";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RandyBishop;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

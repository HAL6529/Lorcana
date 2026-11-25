using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_214_JA_13 : CardInfo
{
    public CardInfo_214_JA_13()
    {
        this.cardNo = "214_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "悪者は居座るもの";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.YrganeRamon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

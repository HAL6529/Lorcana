using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_13 : CardInfo
{
    public CardInfo_006_JA_13()
    {
        this.cardNo = "006_JA_13";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "セリア・メイ";
        this.cardName2 = "フレンドリーな受付嬢";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

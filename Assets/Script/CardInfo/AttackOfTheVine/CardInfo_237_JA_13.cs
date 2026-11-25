using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_237_JA_13 : CardInfo
{
    public CardInfo_237_JA_13()
    {
        this.cardNo = "237_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "カール･フレドリクセン＆ラッセル";
        this.cardName2 = "勇気ある冒険家たち";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NatalieDombois;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}

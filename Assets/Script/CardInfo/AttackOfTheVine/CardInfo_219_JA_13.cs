using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_219_JA_13 : CardInfo
{
    public CardInfo_219_JA_13()
    {
        this.cardNo = "219_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ダッシュ・パー";
        this.cardName2 = "ドッジボール発電ボーイ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}

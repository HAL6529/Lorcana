using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_01 : CardInfo
{
    public CardInfo_058_JA_01()
    {
        this.cardNo = "058_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "ピーター・パンの仲間";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Adrianne Gumaya";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

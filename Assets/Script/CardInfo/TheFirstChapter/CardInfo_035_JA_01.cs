using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_01 : CardInfo
{
    public CardInfo_035_JA_01()
    {
        this.cardNo = "035_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アナ";
        this.cardName2 = "アレンデールの継承者";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Valerio Buonfantino";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_01 : CardInfo
{
    public CardInfo_075_JA_01()
    {
        this.cardNo = "075_JA_01";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ジーニー";
        this.cardName2 = "私はお尋ね者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Giulia Riva";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

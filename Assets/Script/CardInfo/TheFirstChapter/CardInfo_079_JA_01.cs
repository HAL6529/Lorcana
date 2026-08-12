using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_01 : CardInfo
{
    public CardInfo_079_JA_01()
    {
        this.cardNo = "079_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ホーレス";
        this.cardName2 = "どんくさいドロボウ!";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Isaiah Mesq";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

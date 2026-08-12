using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_01 : CardInfo
{
    public CardInfo_120_JA_01()
    {
        this.cardNo = "120_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ|ƒ“ƒS";
        this.cardName2 = "‚¢‚½‚¸‚çŽÒ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Brian Weisz";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_01 : CardInfo
{
    public CardInfo_124_JA_01()
    {
        this.cardNo = "124_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ティブス軍曹";
        this.cardName2 = "がんばりネコ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Cory Godbey";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

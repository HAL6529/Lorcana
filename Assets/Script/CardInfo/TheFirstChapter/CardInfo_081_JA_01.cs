using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_01 : CardInfo
{
    public CardInfo_081_JA_01()
    {
        this.cardNo = "081_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジャスパー";
        this.cardName2 = "ちんけなチンピラ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Jochem Van Gool";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

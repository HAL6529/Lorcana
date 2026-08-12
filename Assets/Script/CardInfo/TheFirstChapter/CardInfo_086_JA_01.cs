using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_086_JA_01 : CardInfo
{
    public CardInfo_086_JA_01()
    {
        this.cardNo = "086_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マッドハッター";
        this.cardName2 = "親切な主催者";
        this.power = 2;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = "Rosa la Barbera";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

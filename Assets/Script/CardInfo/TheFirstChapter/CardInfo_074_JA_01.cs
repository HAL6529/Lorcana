using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_01 : CardInfo
{
    public CardInfo_074_JA_01()
    {
        this.cardNo = "074_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "イケてるお尋ね者";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = "Leonado Giammichele";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

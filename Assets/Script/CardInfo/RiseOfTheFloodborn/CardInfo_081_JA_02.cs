using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_02 : CardInfo
{
    public CardInfo_081_JA_02()
    {
        this.cardNo = "081_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "自信満々の放浪者";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

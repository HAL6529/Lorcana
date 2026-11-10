using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_02 : CardInfo
{
    public CardInfo_070_JA_02()
    {
        this.cardNo = "070_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "óeéÕÇπÇÒ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_02 : CardInfo
{
    public CardInfo_117_JA_02()
    {
        this.cardNo = "117_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ÉÄÅ[ÉâÉì";
        this.cardName2 = "åPó˚íÜÇÃï∫ém";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Cookie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

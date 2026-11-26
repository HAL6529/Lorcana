using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_14 : CardInfo
{
    public CardInfo_017_JA_14()
    {
        this.cardNo = "017_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "パワーライン";
        this.cardName2 = "ミリオン・スター";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer9 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_14 : CardInfo
{
    public CardInfo_070_JA_14()
    {
        this.cardNo = "070_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ドン・カルナージ";
        this.cardName2 = "カーンの運び屋";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DevMadan;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

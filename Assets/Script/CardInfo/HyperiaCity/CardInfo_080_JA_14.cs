using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_14 : CardInfo
{
    public CardInfo_080_JA_14()
    {
        this.cardNo = "080_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "レベッカ・カニングハム";
        this.cardName2 = "やり手の経営者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

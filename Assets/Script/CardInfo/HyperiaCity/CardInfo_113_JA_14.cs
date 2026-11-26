using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_14 : CardInfo
{
    public CardInfo_113_JA_14()
    {
        this.cardNo = "113_JA_14";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "クルエラ";
        this.cardName2 = "滅茶苦茶ドライバー";
        this.power = 5;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

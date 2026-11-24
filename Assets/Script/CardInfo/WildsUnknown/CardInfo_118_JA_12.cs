using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_12 : CardInfo
{
    public CardInfo_118_JA_12()
    {
        this.cardNo = "118_JA_12";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ダッシュ・パー";
        this.cardName2 = "超高速ボーイ";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

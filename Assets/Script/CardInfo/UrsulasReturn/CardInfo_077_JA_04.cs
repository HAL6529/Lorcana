using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_04 : CardInfo
{
    public CardInfo_077_JA_04()
    {
        this.cardNo = "077_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジャック";
        this.cardName2 = "チームのチャレンジャー";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaddieShilt;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

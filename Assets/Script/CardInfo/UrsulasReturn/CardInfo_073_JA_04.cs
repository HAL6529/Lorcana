using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_04 : CardInfo
{
    public CardInfo_073_JA_04()
    {
        this.cardNo = "073_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ガス";
        this.cardName2 = "チーズのチャンピオン";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
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

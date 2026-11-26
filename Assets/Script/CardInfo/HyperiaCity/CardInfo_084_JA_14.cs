using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_084_JA_14 : CardInfo
{
    public CardInfo_084_JA_14()
    {
        this.cardNo = "084_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ボビー・ジムルースキー";
        this.cardName2 = "音響オタク";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrrokesEggleston;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

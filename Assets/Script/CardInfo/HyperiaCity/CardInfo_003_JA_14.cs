using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_14 : CardInfo
{
    public CardInfo_003_JA_14()
    {
        this.cardNo = "003_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マックス・グーフ";
        this.cardName2 = "音楽大好き少年";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

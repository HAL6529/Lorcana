using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_12 : CardInfo
{
    public CardInfo_104_JA_12()
    {
        this.cardNo = "104_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "Mr.インクレディブル";
        this.cardName2 = "ボブ・パー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsiAndGraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_12 : CardInfo
{
    public CardInfo_046_JA_12()
    {
        this.cardNo = "046_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "フロゾン";
        this.cardName2 = "アイスる友";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HyunaLee;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

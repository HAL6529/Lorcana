using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_12 : CardInfo
{
    public CardInfo_123_JA_12()
    {
        this.cardNo = "123_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "若き救出者";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

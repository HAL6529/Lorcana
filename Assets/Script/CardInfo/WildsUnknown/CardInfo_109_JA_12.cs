using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_12 : CardInfo
{
    public CardInfo_109_JA_12()
    {
        this.cardNo = "109_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ゼウス";
        this.cardName2 = "反撃する神";
        this.power = 5;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_06 : CardInfo
{
    public CardInfo_179_JA_06()
    {
        this.cardNo = "179_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヒューバート王";
        this.cardName2 = "フィリップの父";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

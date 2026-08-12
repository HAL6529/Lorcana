using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_01 : CardInfo
{
    public CardInfo_024_JA_01()
    {
        this.cardNo = "024_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ティモン";
        this.cardName2 = "メシ堀り名人";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Juan Diego Leon";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

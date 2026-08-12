using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_01 : CardInfo
{
    public CardInfo_179_JA_01()
    {
        this.cardNo = "179_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "グーンズ";
        this.cardName2 = "マレフィセントの手下";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Cam Kendell";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

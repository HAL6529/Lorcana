using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_07 : CardInfo
{
    public CardInfo_003_JA_07()
    {
        this.cardNo = "003_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ステファン王";
        this.cardName2 = "新米パパ";
        this.power = 4;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

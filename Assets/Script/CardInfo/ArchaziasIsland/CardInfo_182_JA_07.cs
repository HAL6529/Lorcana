using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_07 : CardInfo
{
    public CardInfo_182_JA_07()
    {
        this.cardNo = "182_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アキーラ";
        this.cardName2 = "オオカミの群れの長老";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

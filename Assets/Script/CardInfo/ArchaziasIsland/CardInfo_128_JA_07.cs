using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_07 : CardInfo
{
    public CardInfo_128_JA_07()
    {
        this.cardNo = "128_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スタビントン兄弟";
        this.cardName2 = "眼帯のあるほう";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

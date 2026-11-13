using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_07 : CardInfo
{
    public CardInfo_125_JA_07()
    {
        this.cardNo = "125_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "スタビントン兄弟";
        this.cardName2 = "眼帯のないほう";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FlorenciaVazquez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

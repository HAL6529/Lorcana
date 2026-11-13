using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_07 : CardInfo
{
    public CardInfo_029_JA_07()
    {
        this.cardNo = "029_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ポンゴ";
        this.cardName2 = "大好きなパパ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CecileCarre;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

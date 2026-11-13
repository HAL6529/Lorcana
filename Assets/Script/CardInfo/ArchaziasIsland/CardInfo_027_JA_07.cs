using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_07 : CardInfo
{
    public CardInfo_027_JA_07()
    {
        this.cardNo = "027_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "レック・イット・ラルフ";
        this.cardName2 = "ヒーローズ・デューティ";
        this.power = 3;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

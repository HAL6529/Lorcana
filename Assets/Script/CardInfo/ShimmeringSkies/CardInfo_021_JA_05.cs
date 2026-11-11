using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_05 : CardInfo
{
    public CardInfo_021_JA_05()
    {
        this.cardNo = "021_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "レック・イット・ラルフ";
        this.cardName2 = "デカパン将軍";
        this.power = 6;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HyunaLee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_05 : CardInfo
{
    public CardInfo_143_JA_05()
    {
        this.cardNo = "143_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "パチャ";
        this.cardName2 = "王様のガイド";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

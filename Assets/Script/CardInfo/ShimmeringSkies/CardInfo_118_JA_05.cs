using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_05 : CardInfo
{
    public CardInfo_118_JA_05()
    {
        this.cardNo = "118_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "狙撃の名手";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_05 : CardInfo
{
    public CardInfo_149_JA_05()
    {
        this.cardNo = "149_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クスコ";
        this.cardName2 = "わがままな王様";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_05 : CardInfo
{
    public CardInfo_051_JA_05()
    {
        this.cardNo = "051_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "苛立つパーティー客";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosGomesCabral;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

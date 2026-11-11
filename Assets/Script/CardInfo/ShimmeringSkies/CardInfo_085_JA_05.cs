using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_05 : CardInfo
{
    public CardInfo_085_JA_05()
    {
        this.cardNo = "085_JA_05";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アナ";
        this.cardName2 = "外交的な女王";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DylanBonnerAndCelesteJamneck;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

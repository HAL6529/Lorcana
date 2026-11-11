using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_05 : CardInfo
{
    public CardInfo_054_JA_05()
    {
        this.cardNo = "054_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "悪意の魔女";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ArisZentelis;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

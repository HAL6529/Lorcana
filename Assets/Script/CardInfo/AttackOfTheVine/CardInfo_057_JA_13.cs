using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_13 : CardInfo
{
    public CardInfo_057_JA_13()
    {
        this.cardNo = "057_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "モーフ";
        this.cardName2 = "モノマネこぞう";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

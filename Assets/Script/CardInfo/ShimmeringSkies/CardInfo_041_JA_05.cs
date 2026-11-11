using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_05 : CardInfo
{
    public CardInfo_041_JA_05()
    {
        this.cardNo = "041_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アース・ジャイアント";
        this.cardName2 = "動く山";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

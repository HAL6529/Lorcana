using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_05 : CardInfo
{
    public CardInfo_115_JA_05()
    {
        this.cardNo = "115_JA_05";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ƒfƒiƒq";
        this.cardName2 = "‹w‚ð’Ç‚¤ŒZ";
        this.power = 7;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MikeParker;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

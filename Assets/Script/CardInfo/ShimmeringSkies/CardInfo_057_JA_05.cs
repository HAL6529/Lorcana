using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_05 : CardInfo
{
    public CardInfo_057_JA_05()
    {
        this.cardNo = "057_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ハートの王";
        this.cardName2 = "ふしぎの国の君主";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrittneyHackett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

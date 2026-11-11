using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_05 : CardInfo
{
    public CardInfo_049_JA_05()
    {
        this.cardNo = "049_JA_05";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ジーニー";
        this.cardName2 = "ショーの主役";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

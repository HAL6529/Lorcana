using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_05 : CardInfo
{
    public CardInfo_121_JA_05()
    {
        this.cardNo = "121_JA_05";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "アーサー";
        this.cardName2 = "スズメ初心者";
        this.power = 2;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

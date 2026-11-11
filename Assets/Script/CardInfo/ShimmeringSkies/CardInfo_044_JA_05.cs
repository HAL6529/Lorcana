using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_05 : CardInfo
{
    public CardInfo_044_JA_05()
    {
        this.cardNo = "044_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "ゾウ";
        this.power = 3;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

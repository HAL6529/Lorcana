using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_05 : CardInfo
{
    public CardInfo_045_JA_05()
    {
        this.cardNo = "045_JA_05";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ルイーサ・マドリガル";
        this.cardName2 = "お魅せしマッスル";
        this.power = 4;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

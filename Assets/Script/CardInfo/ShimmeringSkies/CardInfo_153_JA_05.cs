using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_05 : CardInfo
{
    public CardInfo_153_JA_05()
    {
        this.cardNo = "153_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉoÉWÉã";
        this.cardName2 = "ènó˚ÇÃíTí„";
        this.power = 2;
        this.toughness = 1;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Detective};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

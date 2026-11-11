using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_05 : CardInfo
{
    public CardInfo_042_JA_05()
    {
        this.cardNo = "042_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉQÉCÉã";
        this.cardName2 = "ïóÇÃê∏óÏ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

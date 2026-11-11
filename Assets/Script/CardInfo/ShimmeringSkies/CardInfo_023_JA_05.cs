using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_05 : CardInfo
{
    public CardInfo_023_JA_05()
    {
        this.cardNo = "023_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スヴェン";
        this.cardName2 = "おたすけトナカイ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

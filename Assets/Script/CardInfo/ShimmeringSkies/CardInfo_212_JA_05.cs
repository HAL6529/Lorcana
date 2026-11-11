using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_05 : CardInfo
{
    public CardInfo_212_JA_05()
    {
        this.cardNo = "212_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スカー";
        this.cardName2 = "執念深きライオン";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DominikMayer;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}

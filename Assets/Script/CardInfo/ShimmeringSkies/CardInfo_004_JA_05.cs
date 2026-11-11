using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_05 : CardInfo
{
    public CardInfo_004_JA_05()
    {
        this.cardNo = "004_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラット";
        this.cardName2 = "ヘラジカ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
